using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class EmployeesMap : EntityTypeConfiguration<Employees>
    {
        public EmployeesMap()
        {

            HasKey(s => s.EmployeeID);

            ToTable("Employees");

            Property(s => s.EmployeeID).HasColumnName("ID");
            Property(s => s.LastName).HasColumnName("LastName");
            Property(s => s.FirstName).HasColumnName("FirstName");
            Property(s => s.Title).HasColumnName("Title");
            Property(s => s.TitleOfCourtesy).HasColumnName("TitleOfCourtesy");
            Property(s => s.BirthDate).HasColumnName("BirthDate");
            Property(s => s.HireDate).HasColumnName("HireDate");
            Property(s => s.Address).HasColumnName("Address");
            Property(s => s.City).HasColumnName("City");
            Property(s => s.Region).HasColumnName("Region");
            Property(s => s.PostalCode).HasColumnName("PostalCode");
            Property(s => s.Country).HasColumnName("Country");
            Property(s => s.HomePhone).HasColumnName("HomePhone");
            Property(s => s.Extension).HasColumnName("Extension");
            Property(s => s.Photo).HasColumnName("Photo");
            Property(s => s.Notes).HasColumnName("Notes");
            Property(s => s.ReportsTo).HasColumnName("ReportsTo");
            Property(s => s.PhotoPath).HasColumnName("PhotoPath");

            HasRequired(t => t.Emp1).WithMany(t => t.Emp2).HasForeignKey(t => t.ReportsTo);

        }
    }
}
