using System.ComponentModel.DataAnnotations;

namespace Yokaira_AP1_P1.Models
{
    public class Aportes
    {
        [Key]
        public int AporteId { get; set; }

        [Required(ErrorMessage = "Este campo es necesario")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es necesario")]
        [StringLength(100, ErrorMessage ="Error")]
        public string Persona { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es necesario")]
        [StringLength(100, ErrorMessage ="Error")]
        public string Observacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo es necesario")]
        public int Monto { get; set; }
    }
}

