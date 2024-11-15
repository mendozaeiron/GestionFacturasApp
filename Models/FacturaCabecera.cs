using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionFacturasApp.Models
{
    public class FacturaCabecera
    {
        [Key]
        public int IdFactura { get; set; }

        [Required]
        public DateTime FechaFactura { get; set; }

        [Required]
        public int IdEstadoFactura { get; set; }

        [Required, Column(TypeName = "varchar(1000)")]
        public string GlosaFactura { get; set; }

        [Required]
        public int IdProveedor { get; set; }

        [ForeignKey("IdProveedor")]
        public Proveedor Proveedor { get; set; }

        [Required]
        public bool ExentaIVA { get; set; }

        // Propiedad de navegación para los detalles de la factura
        public List<FacturaDetalle> FacturaDetalles { get; set; } = new List<FacturaDetalle>();
    }
}
