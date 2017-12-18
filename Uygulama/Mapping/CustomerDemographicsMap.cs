using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Mapping
{
    public class CustomerDemographicsMap : EntityTypeConfiguration<CustomerDemographics>
    {
        public CustomerDemographicsMap()
        {
            HasKey(t => t.CustomerTypeID);

            Property(t => t.CustomerTypeID).HasColumnName("CustomerTypeID").HasColumnType("nchar").HasMaxLength(10).IsRequired();
            Property(t => t.CustomerDesc).HasColumnName("CustomerDesc");


        }
    }
}
