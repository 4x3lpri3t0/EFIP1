using EFIP1.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFIP1.Services
{
    public class CalificacionesService
    {
        public void AgregarCalificacion(Calificacion calificacion)
        {
            DataBase.Calificaciones.Add(calificacion);
        }

        public ListaProveedores ObtenerProveedores()
        {
            var nombresProveedores = DataBase.Calificaciones
                .Select(x => x.NombreProveedor)
                .Distinct();

            var lista = new ListaProveedores();
            foreach (string nombreProv in nombresProveedores)
            {
                InstanciarProveedor(lista, nombreProv);
            }

            return lista;
        }

        private static void InstanciarProveedor(ListaProveedores lista, string nombreProv)
        {
            List<int> calificaciones = DataBase.Calificaciones
                                .Where(x => x.NombreProveedor == nombreProv)
                                .Select(x => x.Puntaje)
                                .ToList();

            var newProveedor = new Proveedor(nombreProv, calificaciones);

            newProveedor.PuntajePromedio = newProveedor.ObtenerPromedio();

            lista.Proveedores.Add(newProveedor);
        }
    }
}