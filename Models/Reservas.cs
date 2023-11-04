using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuroraRD.Models
{
    public class Reservas
    {
        [Key]
        public int IdReserva {  get; set; }
        [Required]
        [DisplayName("A nombre de quien realiza la reserva?")]
        public string NombreReserva { get; set;}
        [Required]
        [DisplayName("Fecha para la reserva")]
        public DateTime fecha { get; set; }
        [DisplayName("Desea reservar una botella?")]
        [Required]
        public bool Botella { get; set; }
        [Required]
        [Range(1,5)]
        [DisplayName("NUMERO DE ASISTENTES (Max 5 por reserva)")]
        
        public int numAsistentes {  get; set; }

    }
}
