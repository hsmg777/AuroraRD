using System.ComponentModel.DataAnnotations;

namespace AuroraRD.Models
{
    public class Reseñas
    {
        [Key]
        public int IdReserva{ get; set; }

        public string Comentario { get; set; }



    }
}
