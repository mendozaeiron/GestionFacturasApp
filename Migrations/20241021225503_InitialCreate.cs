using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionFacturasApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComunaProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CiudadProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonoProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiroProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "FacturasCabecera",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaFactura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstadoFactura = table.Column<int>(type: "int", nullable: false),
                    GlosaFactura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    ExentaIVA = table.Column<bool>(type: "bit", nullable: false),
                    ProveedorIdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasCabecera", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_FacturasCabecera_Proveedores_ProveedorIdProveedor",
                        column: x => x.ProveedorIdProveedor,
                        principalTable: "Proveedores",
                        principalColumn: "IdProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FacturasDetalle",
                columns: table => new
                {
                    IdFacturaDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFactura = table.Column<int>(type: "int", nullable: false),
                    NroItem = table.Column<int>(type: "int", nullable: false),
                    CodigoItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnidadItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioUnitarioItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotalItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FacturaCabeceraIdFactura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacturasDetalle", x => x.IdFacturaDetalle);
                    table.ForeignKey(
                        name: "FK_FacturasDetalle_FacturasCabecera_FacturaCabeceraIdFactura",
                        column: x => x.FacturaCabeceraIdFactura,
                        principalTable: "FacturasCabecera",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCabecera_ProveedorIdProveedor",
                table: "FacturasCabecera",
                column: "ProveedorIdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasDetalle_FacturaCabeceraIdFactura",
                table: "FacturasDetalle",
                column: "FacturaCabeceraIdFactura");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacturasDetalle");

            migrationBuilder.DropTable(
                name: "FacturasCabecera");

            migrationBuilder.DropTable(
                name: "Proveedores");
        }
    }
}
