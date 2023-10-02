using System.ComponentModel.DataAnnotations;

namespace Yokaira_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }

        [Required(ErrorMessage = "Este campo es necesario")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo es necesario")]
        public string Persona { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es necesario")]
        [Range(1, 5000)]
        public string Observacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es necesario")]
        [Range(1, 5000)]
        public int Monto { get; set; }
        public int AporteId { get; internal set; }
    }
}

