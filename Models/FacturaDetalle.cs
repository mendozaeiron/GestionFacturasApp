using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionFacturasApp.Models
{
    public class FacturaDetalle
    {
        [Key]
        public int IdFacturaDetalle { get; set; }  // Entero autonumérico, clave primaria

        [Required]
        public int IdFactura { get; set; }  // Clave foránea, no acepta nulos, proviene de tblFacturaCabecera

        [Required]
        public int NroItem { get; set; }  // Número del ítem, no acepta nulos, valor inicial 1, se incrementa desde la aplicación

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CodigoItem { get; set; }  // Código del ítem, varchar(50), no acepta nulos

        [Column(TypeName = "varchar(500)")]
        public string NombreItem { get; set; }  // Nombre del ítem, varchar(500), acepta nulos

        [Column(TypeName = "varchar(10)")]
        public string UnidadItem { get; set; }  // Unidad de medida del ítem, varchar(10), acepta nulos

        [Column(TypeName = "decimal(37, 6)")]
        public decimal? CantidadItem { get; set; }  // Cantidad del ítem, acepta nulos

        [Column(TypeName = "decimal(37, 6)")]
        public decimal? PrecioUnitarioItem { get; set; }  // Precio unitario del ítem, acepta nulos

        [Column(TypeName = "decimal(37, 6)")]
        public decimal? SubTotalItem { get; set; }  // Subtotal del ítem, acepta nulos

        // Relación con FacturaCabecera
        public FacturaCabecera FacturaCabecera { get; set; }
    }

}
