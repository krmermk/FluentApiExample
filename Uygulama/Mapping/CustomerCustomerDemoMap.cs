using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class CustomerCustomerDemoMap : EntityTypeConfiguration<CustomerCustomerDemo>
    {
        public CustomerCustomerDemoMap()
        {
            HasKey(a => new { a.CustomerID, a.CustomerTypeID });
            ToTable("CustomerCustomerDemo");
            Property(t => t.CustomerID).HasColumnName("CustomerID");
            Property(t => t.CustomerTypeID).HasColumnName("CustomerTypeID");

            HasRequired(t => t.Customers).WithMany(t => t.CustomerCustomerDemo).HasForeignKey(e => e.CustomerID);
            HasRequired(t => t.CustomerDemographics).WithMany(t => t.CustomerCustomerDemo).HasForeignKey(e => e.CustomerTypeID);

        }
    }
}
