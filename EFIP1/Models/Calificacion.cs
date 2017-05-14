using System.Linq;

namespace EFIP1.Models
{
    public class Calificacion : ICalificacion
    {
        public string NombreProveedor { get; set; }

        public int NroOrdenCompra { get; set; }

        //public DateTime FechaEntrega { get; set; }

        public FormaPago FormaPago { get; set; }

        public int Puntaje { get; set; }

        public string Observaciones { get; set; }
    }
}