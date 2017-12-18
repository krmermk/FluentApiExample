using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class SuppliersMap : EntityTypeConfiguration<Suppliers>
    {
        public SuppliersMap()
        {
            HasKey(s => s.SupplierID);

            ToTable("Suppliers");

            Property(s => s.SupplierID).HasColumnName("ID");
            Property(s => s.CompanyName).HasColumnName("CompanyName");
            Property(s => s.ContactName).HasColumnName("ContactName");
            Property(s => s.ContactTitle).HasColumnName("ContactTitle");
            Property(s => s.Address).HasColumnName("Address");
            Property(s => s.City).HasColumnName("City");
            Property(s => s.Region).HasColumnName("Region");
            Property(s => s.PostalCode).HasColumnName("PostalCode");
            Property(s => s.Country).HasColumnName("Country");
            Property(s => s.Phone).HasColumnName("Phone");
            Property(s => s.Fax).HasColumnName("Fax");
            Property(s => s.HomePage).HasColumnName("HomePage");
         


        }


    }
}
