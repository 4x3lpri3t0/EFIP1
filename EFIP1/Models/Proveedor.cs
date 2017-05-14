using System.Collections.Generic;
using System.Linq;

namespace EFIP1.Models
{
    public class Proveedor : IPromediable
    {
        public Proveedor(string nombre, IList<int> valores)
        {
            Nombre = nombre;
            Valores = valores;
        }

        public string Nombre { get; }

        public IList<int> Valores { get; }

        public double PuntajePromedio { get; set; }

        public double ObtenerPromedio()
        {
            return Valores.Average();
        }
    }
}