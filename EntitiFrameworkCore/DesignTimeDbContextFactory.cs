using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConsoleTest
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataBaseContext>
    {
        //public DataBaseContext CreateDbContext(string[] args)
        //{

        //    // string connectionString = @"Data Source = dev-db2; Initial Catalog = CSR; Integrated Security = SSPI;";
        //    string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = CSR; Integrated Security = SSPI;";
            
        
        //    var builder = new DbContextOptionsBuilder<DataBaseContext>();
     

            
        //    builder.UseSqlServer(connectionString);
        //    return new DataBaseContext(builder.Options);
        //}


        public DataBaseContext CreateDbContext(string[] args)
        {

            // string connectionString = @"Data Source = dev-db2; Initial Catalog = CSR; Integrated Security = SSPI;";
            string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = CSR; Integrated Security = SSPI;";

            var serviceCollection = new ServiceCollection();
            Startup.ConfigureServices(serviceCollection, connectionString
                );
            var serviceProvider = serviceCollection.BuildServiceProvider();


            return serviceProvider.GetService<DataBaseContext>();
        }

    }

}
