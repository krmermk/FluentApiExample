using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class OrdersMap : EntityTypeConfiguration<Orders>
    {
        public OrdersMap()
        {
            HasKey(o => o.OrderID);

            ToTable("Orders");
            Property(o => o.OrderID).HasColumnName("ID");
            Property(o => o.CustomerID).HasColumnName("CustomID");
            Property(o => o.EmployeeID).HasColumnName("EmpID");
            Property(o => o.ShipVia).HasColumnName("ShipVia");
            Property(o => o.OrderDate).HasColumnName("OrderDate");
            Property(o => o.ShippedDate).HasColumnName("ShippedDate");
            Property(o => o.RequiredDate).HasColumnName("RequiredDate");
            Property(o => o.Freight).HasColumnName("Freight");
            Property(o => o.ShipName).HasColumnName("ShipName");
            Property(o => o.ShipAdress).HasColumnName("ShipAdress");
            Property(o => o.ShipCity).HasColumnName("ShipCity");
            Property(o => o.ShipRegion).HasColumnName("ShipRegion");
            Property(o => o.ShipPostalCode).HasColumnName("ShipPostalCode");
            Property(o => o.ShipCountry).HasColumnName("ShipCountry");



            HasRequired(t => t.Employees).
          WithMany(t => t.Orders).
          HasForeignKey(d => d.EmployeeID);

            HasRequired(t => t.Customers).
        WithMany(t => t.Orders).
        HasForeignKey(d => d.CustomerID);

            HasRequired(t => t.Shippers).
         WithMany(t => t.Orders).
         HasForeignKey(d => d.ShipVia);

        }
    }
}
