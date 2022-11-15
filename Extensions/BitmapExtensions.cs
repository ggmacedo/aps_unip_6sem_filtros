using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Filtros.Interfaces;

namespace Filtros.Extensions
{
    public static class BitmapExtensions
    {
        private static int PIXEL_LIMITE_MAXIMO = 255;
        private static int PIXEL_LIMITE_MINIMO = 0;

        public static Bitmap Copiar(this Bitmap imagemOriginal, int largura)
        {
            var tamanhoMaximo = imagemOriginal.Width > imagemOriginal.Height ? imagemOriginal.Width : imagemOriginal.Height;

            float aspecto = tamanhoMaximo / largura;

            Bitmap novaImagem = (imagemOriginal.Width > imagemOriginal.Height ? new Bitmap(largura, (int) (imagemOriginal.Height / aspecto))
                                                                              : new Bitmap((int) (imagemOriginal.Width / aspecto), largura));

            using Graphics grafico = Graphics.FromImage(novaImagem);
            grafico.CompositingQuality = CompositingQuality.HighQuality;
            grafico.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grafico.PixelOffsetMode = PixelOffsetMode.HighQuality;

            grafico.DrawImage(imagemOriginal, new Rectangle(0, 0, novaImagem.Width, novaImagem.Height),
                new Rectangle(0, 0, imagemOriginal.Width, imagemOriginal.Height), GraphicsUnit.Pixel);

            grafico.Flush();

            return novaImagem;
        }
        
        public static Bitmap ExecutarConvolucao(this Bitmap imagemOriginal, IFiltroConvolucional filtro)
        {
            BitmapData dadosOriginais = imagemOriginal.LockBits(
                new Rectangle(0, 0, imagemOriginal.Width, imagemOriginal.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBytes = new byte[dadosOriginais.Stride * dadosOriginais.Height];
            byte[] resultadoBytes = new byte[dadosOriginais.Stride * dadosOriginais.Height];

            Marshal.Copy(dadosOriginais.Scan0, pixelBytes, 0, pixelBytes.Length);

            imagemOriginal.UnlockBits(dadosOriginais);

            double pixelAzul = 0;
            double pixelVerde = 0;
            double pixelVermelho = 0;

            int larguraFiltro = filtro.Matriz.GetLength(1);

            int deslocamentoFiltro = (larguraFiltro - 1) / 2;
            int calculoDeslocamento;
            int byteDeslocamento;

            for (int deslocamentoY = deslocamentoFiltro;
                 deslocamentoY < imagemOriginal.Height - deslocamentoFiltro;
                 deslocamentoY++)
            {
                for (int deslocamentoX = deslocamentoFiltro;
                     deslocamentoX < imagemOriginal.Width - deslocamentoFiltro;
                     deslocamentoX++)
                {
                    byteDeslocamento = deslocamentoY * dadosOriginais.Stride + deslocamentoX * 4;

                    for (int filtroY = -deslocamentoFiltro; filtroY <= deslocamentoFiltro; filtroY++)
                    {
                        for (int filtroX = -deslocamentoFiltro; filtroX <= deslocamentoFiltro; filtroX++)
                        {
                            calculoDeslocamento = byteDeslocamento + (filtroX * 4) + (filtroY * dadosOriginais.Stride);

                            pixelAzul += (pixelBytes[calculoDeslocamento]) * filtro.Matriz[filtroY + deslocamentoFiltro,
                                filtroX + deslocamentoFiltro];

                            pixelVerde += (pixelBytes[calculoDeslocamento + 1]) *
                                          filtro.Matriz[filtroY + deslocamentoFiltro, filtroX + deslocamentoFiltro];

                            pixelVermelho += (pixelBytes[calculoDeslocamento + 2]) *
                                             filtro.Matriz[filtroY + deslocamentoFiltro, filtroX + deslocamentoFiltro];
                        }
                    }

                    pixelAzul = filtro.Fator * pixelAzul;
                    pixelVerde = filtro.Fator * pixelVerde;
                    pixelVermelho = filtro.Fator * pixelVermelho;

                    if (pixelAzul > PIXEL_LIMITE_MAXIMO) pixelAzul = PIXEL_LIMITE_MAXIMO;
                    if (pixelAzul < PIXEL_LIMITE_MINIMO) pixelAzul = PIXEL_LIMITE_MINIMO;

                    if (pixelVerde > PIXEL_LIMITE_MAXIMO) pixelVerde = PIXEL_LIMITE_MAXIMO;
                    if (pixelVerde < PIXEL_LIMITE_MINIMO) pixelVerde = PIXEL_LIMITE_MINIMO;

                    if (pixelVermelho > PIXEL_LIMITE_MAXIMO) pixelVermelho = PIXEL_LIMITE_MAXIMO;
                    if (pixelVermelho < PIXEL_LIMITE_MINIMO) pixelVermelho = PIXEL_LIMITE_MINIMO;

                    resultadoBytes[byteDeslocamento] = (byte) pixelAzul;
                    resultadoBytes[byteDeslocamento + 1] = (byte) pixelVerde;
                    resultadoBytes[byteDeslocamento + 2] = (byte) pixelVermelho;
                    resultadoBytes[byteDeslocamento + 3] = 255;
                }
            }

            Bitmap novaImagem = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);

            BitmapData dadosResultado = novaImagem.LockBits(new Rectangle(0, 0, novaImagem.Width, novaImagem.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultadoBytes, 0, dadosResultado.Scan0, resultadoBytes.Length);
            novaImagem.UnlockBits(dadosResultado);

            return novaImagem;
        }
    }
}