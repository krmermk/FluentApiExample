using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class TerritoriesMap : EntityTypeConfiguration<Territories>
    {
        public TerritoriesMap()
        {
            HasKey(s => s.TerritoryID);

            ToTable("Territories");

            Property(s => s.TerritoryID).HasColumnName("ID");
            Property(s => s.TerritoryDescription).HasColumnName("TerritoryDescription");
            Property(s => s.RegionID).HasColumnName("RegionID");


            HasRequired(t => t.Reggi).
           WithMany(t => t.Territories).
           HasForeignKey(d => d.RegionID);
        }
    }
}
