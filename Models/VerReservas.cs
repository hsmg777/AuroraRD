using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AuroraRD.Models
{
    public class RootobjectsVer
    {
        public List<Class1> Reservas { get; set; }
    }

    public class Class1
    {
        public int idReserva { get; set; }
        public string nombre { get; set; }
        public int numeroPersonas { get; set; }
        public string telefono { get; set; }
        public DateTime fecha { get; set; }
        public string horaLlega { get; set; }

    }
}
