using System.ComponentModel.DataAnnotations;

namespace AuroraRD.Models
{
    public class Liquido
    {
        [Key]
        public int Id { get; set; }
        public string imagen { get; set; }

        [Range(1,14)]
        public int Precio { get; } = 14;
        [Range(1,99)]
        
        public int cantidad {  get; set; }

      //public int ReservasId {get; set;}
      //public Reservas Reservas {get; set;]
    }
}
