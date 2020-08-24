using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherMonitoringStation.DAL.Migrations
{
    public partial class CreatWeatherMonitoringStationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: true),
                    Temprature = table.Column<float>(nullable: false),
                    Pressure = table.Column<int>(nullable: false),
                    Humadity = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherInformation", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherInformation",
                columns: new[] { "Id", "City", "Date", "Humadity", "Pressure", "Temprature" },
                values: new object[,]
                {
                    { 1, "London", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1017, 294.45f },
                    { 2, "London", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1018, 294.44f },
                    { 3, "London", new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1019, 290.44f },
                    { 4, "London", new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1010, 291.43f },
                    { 5, "London", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1011, 294.3f },
                    { 6, "London", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1012, 293.44f },
                    { 7, "London", new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 1012, 292.44f },
                    { 8, "New York", new DateTime(2020, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1017, 294.45f },
                    { 9, "New York", new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 1018, 294.44f },
                    { 10, "New York", new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 1019, 290.44f },
                    { 11, "New York", new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 1010, 291.43f },
                    { 12, "New York", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1011, 294.3f },
                    { 13, "New York", new DateTime(2020, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1012, 293.44f },
                    { 14, "New York", new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 1012, 292.44f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherInformation");
        }
    }
}
