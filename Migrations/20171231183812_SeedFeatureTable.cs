using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CarDealer.Migrations
{
    public partial class SeedFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Color - Blue');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Color - Black');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Color - Red');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Auto Pilot');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Sunroof');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Moonroof');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('360 Degree Roof');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Rear Radar & Camera');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Side Radar & Camera');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('CamCorder');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('6 Gear Auto-transmission');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Luxury Stereo System');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Leather Seats');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Heating Seats');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Alloy Wheel - 17');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Alloy Wheel - 19');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Alloy Wheel - 21');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Remote Start');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Central Control System');");
            migrationBuilder.Sql("INSERT INTO CarDealer.Features (Name) VALUES('Disk Brake');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CarDearler.Features;");
        }
    }
}
