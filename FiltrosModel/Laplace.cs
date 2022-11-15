using Filtros.Interfaces;

namespace Filtros.FiltrosModel
{
    public class Laplace : IFiltro
    {
        public string NomeFiltro => "Laplace";

        private const int LIMITE_PIXEL_MINIMO = 0;
        private const int LIMITE_PIXEL_MAXIMO = 255;
        
        public Bitmap Aplicar(Bitmap imagemOriginal)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            int[,] Laplace =
            {
                {0, 1, 0},
                {1, -4, 1},
                {0, 1, 0}
            };
            
            int pixelsVermelho = 0;
            int pixelsVerde = 0;
            int pixelsAzul = 0;
            
            Bitmap novaImagem = new Bitmap(largura, altura);
            
            for (var i = 0; i < altura - 2; i++)
            {
                for (var j = 0; j < largura - 2; j++)
                {
                    for (var auxiliar1 = 0; auxiliar1 < 3; auxiliar1++)
                    {
                        for (var auxiliar2 = 0; auxiliar2 < 3; auxiliar2++)
                        {
                            pixelsVermelho += imagemOriginal.GetPixel(j + auxiliar1, i + auxiliar2).R * Laplace[auxiliar2, auxiliar1];
                            pixelsVerde += imagemOriginal.GetPixel(j + auxiliar1, i + auxiliar2).G * Laplace[auxiliar2, auxiliar1];
                            pixelsAzul += imagemOriginal.GetPixel(j + auxiliar1, i + auxiliar2).B * Laplace[auxiliar2, auxiliar1];
                        }
                    }

                    if (pixelsVermelho < LIMITE_PIXEL_MINIMO) pixelsVermelho = LIMITE_PIXEL_MINIMO;
                    if (pixelsVermelho > LIMITE_PIXEL_MAXIMO) pixelsVermelho = LIMITE_PIXEL_MAXIMO;
                    
                    if (pixelsVerde < LIMITE_PIXEL_MINIMO) pixelsVerde = LIMITE_PIXEL_MINIMO;
                    if (pixelsVerde > LIMITE_PIXEL_MAXIMO) pixelsVerde = LIMITE_PIXEL_MAXIMO;
                    
                    if (pixelsAzul < LIMITE_PIXEL_MINIMO) pixelsAzul = LIMITE_PIXEL_MINIMO;
                    if (pixelsAzul > LIMITE_PIXEL_MAXIMO) pixelsAzul = LIMITE_PIXEL_MAXIMO;

                    novaImagem.SetPixel(j + 1, i + 1, Color.FromArgb(255, pixelsVermelho, pixelsVerde, pixelsAzul));
                    
                    pixelsVermelho = 0;
                    pixelsVerde = 0;
                    pixelsAzul = 0;

                }
            }
            return novaImagem;
        }
    }
}
