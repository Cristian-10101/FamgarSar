using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamgarSar.Data.Migrations
{
    public partial class AddAcosoLaborals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcosoLaborals",
                columns: table => new
                {
                    AcosoLaboralId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDiligencionamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConCopia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dependence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quejas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcosoLaborals", x => x.AcosoLaboralId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcosoLaborals");
        }
    }
}
