using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionFacturasApp.Migrations
{
    /// <inheritdoc />
    public partial class AddFacturaDetalleRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCabecera_Proveedores_ProveedorIdProveedor",
                table: "FacturasCabecera");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCabecera_ProveedorIdProveedor",
                table: "FacturasCabecera");

            migrationBuilder.DropColumn(
                name: "ProveedorIdProveedor",
                table: "FacturasCabecera");

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCabecera_IdProveedor",
                table: "FacturasCabecera",
                column: "IdProveedor");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCabecera_Proveedores_IdProveedor",
                table: "FacturasCabecera",
                column: "IdProveedor",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacturasCabecera_Proveedores_IdProveedor",
                table: "FacturasCabecera");

            migrationBuilder.DropIndex(
                name: "IX_FacturasCabecera_IdProveedor",
                table: "FacturasCabecera");

            migrationBuilder.AddColumn<int>(
                name: "ProveedorIdProveedor",
                table: "FacturasCabecera",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FacturasCabecera_ProveedorIdProveedor",
                table: "FacturasCabecera",
                column: "ProveedorIdProveedor");

            migrationBuilder.AddForeignKey(
                name: "FK_FacturasCabecera_Proveedores_ProveedorIdProveedor",
                table: "FacturasCabecera",
                column: "ProveedorIdProveedor",
                principalTable: "Proveedores",
                principalColumn: "IdProveedor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
