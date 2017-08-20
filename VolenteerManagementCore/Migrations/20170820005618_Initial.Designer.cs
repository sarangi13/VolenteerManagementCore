using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VolenteerManagementCore.Models;

namespace VolenteerManagementCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170820005618_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VolenteerManagementCore.Models.Volenteer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ApprovalStatus");

                    b.Property<int>("Availalibity");

                    b.Property<string>("Center");

                    b.Property<bool>("Drivers");

                    b.Property<string>("Education");

                    b.Property<string>("Email");

                    b.Property<string>("EmergencyAddress");

                    b.Property<string>("EmergencyContact");

                    b.Property<string>("EmergencyEmail");

                    b.Property<long>("EmergencyPhone");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Lincense");

                    b.Property<string>("Password");

                    b.Property<long>("Phone");

                    b.Property<string>("Skills");

                    b.Property<bool>("Ssn");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Volenteers");
                });
        }
    }
}
