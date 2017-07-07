using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Validation.Models;

namespace Validation.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20160412040545_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Validation.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Designation");

                    b.Property<string>("Name");

                    b.Property<decimal>("Salary");

                    b.HasKey("EmployeeId");
                });
        }
    }
}
