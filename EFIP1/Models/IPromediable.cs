using System.Collections.Generic;
using System.Linq;

namespace EFIP1.Models
{
    public interface IPromediable
    {
        IList<int> Valores { get; }

        double ObtenerPromedio();
    }
}