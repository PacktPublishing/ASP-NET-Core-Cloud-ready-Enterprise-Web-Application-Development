using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;

namespace Validation.Models
{
    public class EmployeeDbContext : DbContext
    {

        public IConfigurationRoot Configuration { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(Configuration.Get<string>("Data:DefaultConnection:ConnectionString"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
