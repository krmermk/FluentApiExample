using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class ProductsMap : EntityTypeConfiguration<Products>
    {
        public ProductsMap()
        {
            HasKey(t => t.ID);

            ToTable("Products");

            Property(t => t.ID).HasColumnName("ID");
            Property(t => t.ProductName).HasColumnName("Name");
            Property(t => t.SupplierID).HasColumnName("SuppID");
            Property(t => t.CategoryID).HasColumnName("CategoryID");
            Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
            Property(t => t.Discontinued).HasColumnName("Discontinued").IsRequired();


            HasRequired(t => t.Categories).
                WithMany(t => t.Product).
                HasForeignKey(d => d.CategoryID);

            HasRequired(t => t.Suppliers)
                .WithMany(t => t.Products)
                .HasForeignKey(s => s.SupplierID);

        }
    }
}
