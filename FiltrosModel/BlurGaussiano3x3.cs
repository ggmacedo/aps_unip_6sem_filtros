using Filtros.Extensions;
using Filtros.Interfaces;

namespace Filtros.FiltrosModel
{
    public class BlurGaussiano3x3 : IFiltroConvolucional
    {
        public string NomeFiltro => "Blur Gaussiano 3x3";

        public double[,] Matriz =>
            new double[,] 
            { 
                { 1, 2, 1, }, 
                { 2, 4, 2, }, 
                { 1, 2, 1, }
            };

        public double Fator => 1.0 / 16.0;
        
        public Bitmap Aplicar(Bitmap imagemOriginal) => imagemOriginal.ExecutarConvolucao(this);
    }
}
