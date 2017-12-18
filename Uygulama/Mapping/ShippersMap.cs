using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class ShippersMap : EntityTypeConfiguration<Shippers>
    {
        public ShippersMap()
        {

            HasKey(t => t.ShipperID);

            ToTable("Shippers");
            Property(t => t.ShipperID).HasColumnName("ID");
            Property(t => t.CompanyName).HasColumnName("CompanyName");
            Property(t => t.Phone).HasColumnName("Phone");

           
        }
    }
}
