using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Mapping;

namespace Uygulama
{
    public class NortwindDbContext:DbContext
    {
        public NortwindDbContext()
            : base("MyConnectionString")
        {

        }
        public DbSet<Products> MyProducts { get; set; }
        public DbSet<Categories> MyCategories { get; set; }
        public DbSet<CustomerCustomerDemo> MyCustomerCustomerDemo { get; set; }
        public DbSet<CustomerDemographics> MyCustomerDemographics { get; set; }
        public DbSet<Suppliers> MySuppliers { get; set; }
        public DbSet<Orders> MyOrders { get; set; }
        public DbSet<OrderDetails> MyOrderDetails { get; set; }
        public DbSet<Shippers> MyShippers { get; set; }
        public DbSet<Employees> MyEmployees { get; set; }
        public DbSet<EmployeeTerritories> MyEmployeeTerritories { get; set; }
        public DbSet<Region> MyRegion { get; set; }
        public DbSet<Territories> MyTerritories { get; set; }
        public DbSet<Customers> MyCustomers { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriesMap());
            modelBuilder.Configurations.Add(new CustomerCustomerDemoMap());
            modelBuilder.Configurations.Add(new CustomerDemographicsMap());
            modelBuilder.Configurations.Add(new ProductsMap());
            modelBuilder.Configurations.Add(new SuppliersMap());
            modelBuilder.Configurations.Add(new OrdersMap());
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new ShippersMap());
            modelBuilder.Configurations.Add(new EmployeesMap());
            modelBuilder.Configurations.Add(new EmployeeTerritoriesMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new TerritoriesMap());
            modelBuilder.Configurations.Add(new CustomersMap());

        }
    }
}
