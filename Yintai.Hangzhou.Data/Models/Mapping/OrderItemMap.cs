using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Yintai.Hangzhou.Data.Models.Mapping
{
    public partial class OrderItemEntityMap : EntityTypeConfiguration<OrderItemEntity>
    {
        public OrderItemEntityMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.OrderNo, t.ProductId, t.ProductDesc, t.Quantity, t.ItemPrice, t.ExtendPrice, t.BrandId, t.StoreId, t.CreateUser, t.CreateDate, t.UpdateUser, t.UpdateDate, t.Status });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.OrderNo)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductDesc)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.StoreItemNo)
                .HasMaxLength(20);

            this.Property(t => t.StoreItemDesc)
                .HasMaxLength(200);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExtendPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StoreId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreateUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpdateUser)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Status)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderItem");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.ProductDesc).HasColumnName("ProductDesc");
            this.Property(t => t.StoreItemNo).HasColumnName("StoreItemNo");
            this.Property(t => t.StoreItemDesc).HasColumnName("StoreItemDesc");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.ItemPrice).HasColumnName("ItemPrice");
            this.Property(t => t.ExtendPrice).HasColumnName("ExtendPrice");
            this.Property(t => t.BrandId).HasColumnName("BrandId");
            this.Property(t => t.StoreId).HasColumnName("StoreId");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateUser).HasColumnName("UpdateUser");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.Status).HasColumnName("Status");
		Init();
        }

		partial void Init();
    }
}
