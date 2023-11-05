using System.ComponentModel.DataAnnotations;

namespace AuroraRD.Models
{
    public class Liquido
    {
        public int Id { get; set; }
        public string imagen { get; set; }
        [Range(1,14)]
        public int Precio { get; set; }
        [Range(1, 99)]
        public int cantidad {  get; set; }
    }
}
