using System.Linq;

namespace EFIP1.Models
{
    public class Calificacion : ICalificacion
    {
        public int NroProveedor { get; set; }

        public int NroOrdenCompra { get; set; }

        //public DateTime FechaEntrega { get; set; }

        public FormaPago FormaPago { get; set; }

        public byte Puntaje { get; set; }

        public string Observaciones { get; set; }
    }
}