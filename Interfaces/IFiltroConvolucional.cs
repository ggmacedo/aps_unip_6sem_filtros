using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros.Interfaces
{
    public interface IFiltroConvolucional : IFiltro
    {
        public double[,] Matriz { get; }
        public double Fator { get; }
    }
}
