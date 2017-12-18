using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class OrderDetailsMap : EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            HasKey(od => new { od.OrderID, od.ProductID });

            ToTable("OrderDetails");
            Property(od => od.OrderID).HasColumnName("OrderID");
            Property(od => od.ProductID).HasColumnName("ProductID");
            Property(od => od.UnitPrice).HasColumnName("UnitPrice");
            Property(od => od.Quantity).HasColumnName("Quantity");
            Property(od => od.Discount).HasColumnName("Discount");


            HasRequired(od => od.Order).
             WithMany(od=> od.OrderDetail).
             HasForeignKey(d => d.OrderID);

            HasRequired(od => od.Product).
                WithMany(od => od.OrderDetail).
                HasForeignKey(d => d.ProductID);
           

            


           



        }
    }
}
