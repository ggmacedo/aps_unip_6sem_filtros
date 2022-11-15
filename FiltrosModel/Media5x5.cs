using Filtros.Extensions;
using Filtros.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros.FiltrosModel
{
    public class Media5x5 : IFiltroConvolucional
    {
        public string NomeFiltro => "Média 5x5";

        public double[,] Matriz =>
            new double[,]
            { 
                { 1, 1, 1, 1, 1 }, 
                { 1, 1, 1, 1, 1 }, 
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }, 
            };

        public double Fator => 1.0 / 25.0;
        
        public Bitmap Aplicar(Bitmap imagemOriginal) => imagemOriginal.ExecutarConvolucao(this);
    }
}
