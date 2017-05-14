using System.Collections.Generic;
using System.Linq;

namespace EFIP1.Models
{
    public class ListaProveedores
    {
        public ListaProveedores()
        {
            this.Proveedores = new List<Proveedor>();
        }

        public List<Proveedor> Proveedores { get; set; }
    }
}