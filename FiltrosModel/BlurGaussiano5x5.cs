using Filtros.Interfaces;
using Filtros.Extensions;

namespace Filtros.FiltrosModel
{
    public class BlurGaussiano5x5 : IFiltroConvolucional
    {
        public string NomeFiltro => "Blur Gaussiano 5x5";

        public double[,] Matriz =>
            new double[,]
            { 
                { 2, 04, 05, 04, 2 }, 
                { 4, 09, 12, 09, 4 }, 
                { 5, 12, 15, 12, 5 },
                { 4, 09, 12, 09, 4 },
                { 2, 04, 05, 04, 2 }, 
            };

        public double Fator => 1.0 / 159.0;
        
        public Bitmap Aplicar(Bitmap imagemOriginal) => imagemOriginal.ExecutarConvolucao(this);
    }
}
