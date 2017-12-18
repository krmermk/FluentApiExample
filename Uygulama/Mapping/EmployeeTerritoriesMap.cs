using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class EmployeeTerritoriesMap : EntityTypeConfiguration<EmployeeTerritories>
    {
        public EmployeeTerritoriesMap()
        {
            HasKey(s => new { s.EmployeeID, s.TerritoryID });

            ToTable("EmployeeTerritories");

            Property(s => s.EmployeeID).HasColumnName("EmployeeID");
            Property(s => s.TerritoryID).HasColumnName("TerritoryID");

           
            
            HasRequired(t => t.Territories).
            WithMany(t => t.EmployeeTerritories).
            HasForeignKey(d => d.TerritoryID);


           HasRequired(t => t.Employees).
           WithMany(t => t.EmployeeTerritories).
           HasForeignKey(d => d.EmployeeID);


        }
    }
}
