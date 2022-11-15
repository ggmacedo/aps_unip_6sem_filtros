using Filtros.Extensions;
using Filtros.Interfaces;

namespace Filtros.FiltrosModel
{
    public class Media : IFiltroConvolucional
    {
        public string NomeFiltro => "Média";

        public double[,] Matriz =>
            new double[,] 
            { 
                { 1, 1, 1, }, 
                { 1, 1, 1, }, 
                { 1, 1, 1, }
            };

        public double Fator => 1.0 / 9.0;

        public Bitmap Aplicar(Bitmap imagemOriginal) => imagemOriginal.ExecutarConvolucao(this);
    }
}
