using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VolenteerManagementCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volenteers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ApprovalStatus = table.Column<string>(nullable: true),
                    Availalibity = table.Column<int>(nullable: false),
                    Center = table.Column<string>(nullable: true),
                    Drivers = table.Column<bool>(nullable: false),
                    Education = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmergencyAddress = table.Column<string>(nullable: true),
                    EmergencyContact = table.Column<string>(nullable: true),
                    EmergencyEmail = table.Column<string>(nullable: true),
                    EmergencyPhone = table.Column<long>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Lincense = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<long>(nullable: false),
                    Skills = table.Column<string>(nullable: true),
                    Ssn = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volenteers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volenteers");
        }
    }
}
