using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarStore.Migrations
{
    /// <inheritdoc />
    public partial class CarStore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProdID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProdID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CapacitateaMotorului = table.Column<float>(type: "real", nullable: false),
                    TipulCombustibilului = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transmisie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipTractiune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumarUsi = table.Column<int>(type: "int", nullable: false),
                    NumarLocuri = table.Column<int>(type: "int", nullable: false),
                    ProdID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProducerProdID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cars_Producers_ProducerProdID",
                        column: x => x.ProducerProdID,
                        principalTable: "Producers",
                        principalColumn: "ProdID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ProducerProdID",
                table: "Cars",
                column: "ProducerProdID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
