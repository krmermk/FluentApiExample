using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            HasKey(r => r.RegionID);

            ToTable("Region");

            Property(s => s.RegionID).HasColumnName("ID");
            Property(s => s.RegionDescription).HasColumnName("RegionDescription");
        }

    }
}
