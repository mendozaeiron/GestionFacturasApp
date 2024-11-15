using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionFacturasApp.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required, Column(TypeName = "varchar(500)")]
        public string NombreProveedor { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ComunaProveedor { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CiudadProveedor { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string FonoProveedor { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string RutProveedor { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string GiroProveedor { get; set; }

        public List<FacturaCabecera> FacturasCabecera { get; set; }
    }

}
