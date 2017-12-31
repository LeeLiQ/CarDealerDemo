using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarDealer.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seed Makes table. 
            // A better way to do the insert is to use a variable to replace (select id from ........)
            migrationBuilder.Sql("INSERT INTO CarDealer.Makes (Name) VALUES('Tesla')");
            migrationBuilder.Sql("INSERT INTO CarDealer.Makes (Name) VALUES('BMW')");
            migrationBuilder.Sql("INSERT INTO CarDealer.Makes (Name) VALUES('Honda')");

            // Seed Models table
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Model S', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Tesla'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Model X', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Tesla'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Model 3', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Tesla'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('SemiTruck', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Tesla'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Roadster', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Tesla'));");

            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('M3', (SELECT Id FROM CarDealer.Makes WHERE Name = 'BMW'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('X5', (SELECT Id FROM CarDealer.Makes WHERE Name = 'BMW'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Z4', (SELECT Id FROM CarDealer.Makes WHERE Name = 'BMW'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('i8', (SELECT Id FROM CarDealer.Makes WHERE Name = 'BMW'));");

            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Civic', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Honda'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Accrod', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Honda'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('Pilot', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Honda'));");
            migrationBuilder.Sql("INSERT INTO CarDealer.Models (Name,MakeId) VALUES('NSX', (SELECT Id FROM CarDealer.Makes WHERE Name = 'Honda'));");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CarDealer.Makes;");
            // There is no need to delete from Models since the FK and cascade option.
        }
    }
}
