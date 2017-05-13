using EFIP1.Models;
using System.Linq;

namespace EFIP1.Services
{
    public class CalificacionesService
    {
        public void AddCalificacion(Calificacion calificacion)
        {
            DataBase.Calificaciones.Add(calificacion);
        }
    }
}