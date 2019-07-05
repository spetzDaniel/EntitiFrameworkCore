using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class Startup
    {
        public static void ConfigureServices(
            IServiceCollection serviceCollection,
            string connectionString)
        {

            var builder = new DbContextOptionsBuilder<DataBaseContext>();
            builder.UseSqlServer(connectionString);

           

        }

        public static void RunMigrations(IServiceProvider serviceProvider)
        {
           
        }
    }
}
