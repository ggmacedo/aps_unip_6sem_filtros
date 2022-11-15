using Filtros.Interfaces;

namespace Filtros.FiltrosModel
{
    public class Mediana : IFiltro
    {
        public string NomeFiltro => "Mediana";

        public Bitmap Aplicar(Bitmap imagemOriginal)
        {
            int largura = imagemOriginal.Width;
            int altura = imagemOriginal.Height;
            
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            int[] vetor = new int[9];

            Bitmap novaImagem = new Bitmap(largura, altura);


            for (var i = 1; i < largura - 1; i++)
            {
                for (var j = 1; j < altura - 1; j++)
                {
                    todosPixeisR[0] = imagemOriginal.GetPixel(i - 1, j - 1).R;
                    todosPixeisR[1] = imagemOriginal.GetPixel(i - 1, j).R;
                    todosPixeisR[2] = imagemOriginal.GetPixel(i - 1, j + 1).R;

                    todosPixeisR[3] = imagemOriginal.GetPixel(i, j - 1).R;
                    todosPixeisR[4] = imagemOriginal.GetPixel(i, j).R;
                    todosPixeisR[5] = imagemOriginal.GetPixel(i, j + 1).R;

                    todosPixeisR[6] = imagemOriginal.GetPixel(i + 1, j - 1).R;
                    todosPixeisR[7] = imagemOriginal.GetPixel(i + 1, j).R;
                    todosPixeisR[8] = imagemOriginal.GetPixel(i + 1, j + 1).R;

                    vetor = todosPixeisR.OrderBy(x => x).ToArray();
                    var pixelR = vetor[4];


                    todosPixeisG[0] = imagemOriginal.GetPixel(i - 1, j - 1).G;
                    todosPixeisG[1] = imagemOriginal.GetPixel(i - 1, j).G;
                    todosPixeisG[2] = imagemOriginal.GetPixel(i - 1, j + 1).G;

                    todosPixeisG[3] = imagemOriginal.GetPixel(i, j - 1).G;
                    todosPixeisG[4] = imagemOriginal.GetPixel(i, j).G;
                    todosPixeisG[5] = imagemOriginal.GetPixel(i, j + 1).G;

                    todosPixeisG[6] = imagemOriginal.GetPixel(i + 1, j - 1).G;
                    todosPixeisG[7] = imagemOriginal.GetPixel(i + 1, j).G;
                    todosPixeisG[8] = imagemOriginal.GetPixel(i + 1, j + 1).G;

                    vetor = todosPixeisG.OrderBy(x => x).ToArray();
                    var pixelG = vetor[4];


                    todosPixeisB[0] = imagemOriginal.GetPixel(i - 1, j - 1).B;
                    todosPixeisB[1] = imagemOriginal.GetPixel(i - 1, j).B;
                    todosPixeisB[2] = imagemOriginal.GetPixel(i - 1, j + 1).B;

                    todosPixeisB[3] = imagemOriginal.GetPixel(i, j - 1).B;
                    todosPixeisB[4] = imagemOriginal.GetPixel(i, j).B;
                    todosPixeisB[5] = imagemOriginal.GetPixel(i, j + 1).B;

                    todosPixeisB[6] = imagemOriginal.GetPixel(i + 1, j - 1).B;
                    todosPixeisB[7] = imagemOriginal.GetPixel(i + 1, j).B;
                    todosPixeisB[8] = imagemOriginal.GetPixel(i + 1, j + 1).B;

                    vetor = todosPixeisB.OrderBy(x => x).ToArray();
                    var pixelB = vetor[4];


                    todosPixeisA[0] = imagemOriginal.GetPixel(i - 1, j - 1).A;
                    todosPixeisA[1] = imagemOriginal.GetPixel(i - 1, j).A;
                    todosPixeisA[2] = imagemOriginal.GetPixel(i - 1, j + 1).A;

                    todosPixeisA[3] = imagemOriginal.GetPixel(i, j - 1).A;
                    todosPixeisA[4] = imagemOriginal.GetPixel(i, j).A;
                    todosPixeisA[5] = imagemOriginal.GetPixel(i, j + 1).A;

                    todosPixeisA[6] = imagemOriginal.GetPixel(i + 1, j - 1).A;
                    todosPixeisA[7] = imagemOriginal.GetPixel(i + 1, j).A;
                    todosPixeisA[8] = imagemOriginal.GetPixel(i + 1, j + 1).A;

                    vetor = todosPixeisA.OrderBy(x => x).ToArray();
                    var pixelA = vetor[4];


                    novaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));
                }
            }
            return novaImagem;
        }
    }
}
