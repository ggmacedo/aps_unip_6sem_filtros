using Filtros.Interfaces;

namespace Filtros.FiltrosModel
{
    public class Sobel : IFiltro
    {
        public string NomeFiltro => "Sobel";

        public Bitmap Aplicar(Bitmap imagemOriginal)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;

            int[,] Sobely =
            {
                {-1, 0, 1},
                {-2, 0, 2},
                {-1, 0, 1}
            };

            int[,] Sobelx =
            {
                {-1, -2, -1},
                {0, 0, 0},
                {1, 2, 1}
            };

            int[,] pixelsVermelho = new int[largura, altura];
            int[,] pixelsVerde = new int[largura, altura];
            int[,] pixelsAzul = new int[largura, altura];

            Bitmap novaImagem = new Bitmap(largura, altura);
            int limite = 128 * 128;

            for (int i = 0; i < largura; i++)
            {
                for (int j = 0; j < altura; j++)
                {
                    pixelsVermelho[i, j] = imagemOriginal.GetPixel(i, j).R;
                    pixelsVerde[i, j] = imagemOriginal.GetPixel(i, j).G;
                    pixelsAzul[i, j] = imagemOriginal.GetPixel(i, j).B;
                }
            }
            
            for (int i = 1; i < largura - 1; i++)
            {
                for (int j = 1; j < altura - 1; j++)
                {
                    var novoRx = 0;
                    var novoRy = 0;
                    var novoGx = 0;
                    var novoGy = 0;
                    var novoBx = 0;
                    var novoBy = 0;
                    
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novoRx += Sobelx[x + 1, y + 1] * pixelsVermelho[i + y, j + x];
                            novoRy += Sobely[x + 1, y + 1] * pixelsVermelho[i + y, j + x];
                            novoGx += Sobelx[x + 1, y + 1] * pixelsVerde[i + y, j + x];
                            novoGy += Sobely[x + 1, y + 1] * pixelsVerde[i + y, j + x];
                            novoBx += Sobelx[x + 1, y + 1] * pixelsAzul[i + y, j + x];
                            novoBy += Sobely[x + 1, y + 1] * pixelsAzul[i + y, j + x];
                        }
                    }

                    if (novoRx * novoRx + novoRy * novoRy > limite ||
                        novoGx * novoGx + novoGy * novoGy > limite ||
                        novoBx * novoBx + novoBy * novoBy > limite)
                    {
                        novaImagem.SetPixel(i, j, Color.Transparent);
                    }
                    else
                    {
                        novaImagem.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return novaImagem;
        }
    }
}
