using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace TunisaMall.data.Models.Mapping
{
    public class productMap : EntityTypeConfiguration<product>
    {
        public productMap()
        {
            // Primary Key
            this.HasKey(t => t.idProduct);

            // Properties
            this.Property(t => t.libelle)
                .HasMaxLength(255);

            this.Property(t => t.state)
                .HasMaxLength(255);

            this.Property(t => t.tag)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("product", "pidevtunisiamall");
            this.Property(t => t.idProduct).HasColumnName("idProduct");
            this.Property(t => t.buyPrice).HasColumnName("buyPrice");
            this.Property(t => t.criticalZone).HasColumnName("criticalZone");
            this.Property(t => t.expDate).HasColumnName("expDate");
            this.Property(t => t.libelle).HasColumnName("libelle");
            this.Property(t => t.qte).HasColumnName("qte");
            this.Property(t => t.sellPrice).HasColumnName("sellPrice");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.tag).HasColumnName("tag");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.Promotion_idPromotion).HasColumnName("Promotion_idPromotion");
            this.Property(t => t.IdPromotionSuggest_fk).HasColumnName("IdPromotionSuggest_fk");
            this.Property(t => t.IdStore).HasColumnName("IdStore");
            this.Property(t => t.IdSubCategory).HasColumnName("IdSubCategory");

            // Relationships
            this.HasOptional(t => t.store)
                .WithMany(t => t.products)
                .HasForeignKey(d => d.IdStore);
            this.HasOptional(t => t.promotionsuggest)
                .WithMany(t => t.products)
                .HasForeignKey(d => d.IdPromotionSuggest_fk);
            this.HasOptional(t => t.promotion)
                .WithMany(t => t.products)
                .HasForeignKey(d => d.Promotion_idPromotion);
            this.HasOptional(t => t.subcategory)
                .WithMany(t => t.products)
                .HasForeignKey(d => d.IdSubCategory);

        }
    }
}
