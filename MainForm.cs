using Filtros.Extensions;
using Filtros.FiltrosModel;
using Filtros.Interfaces;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Filtros
{
    public partial class MainForm : Form
    {
        private Bitmap? _imagemOriginal;
        private Bitmap? _imagemNormalizada;
        private Bitmap? _imagemFinal;

        public MainForm()
        {
            InitializeComponent();
            PreencherFiltros();
        }

        private void PreencherFiltros()
        {
            var filtros = new List<IFiltro>()
            {
                new Sobel(),
                new Laplace(),
                new Media(),
                new Media5x5(),
                new Mediana(),
                new BlurGaussiano3x3(),
                new BlurGaussiano5x5(),
            };

            comboFiltros.DataSource = filtros;
            comboFiltros.DisplayMember = "NomeFiltro";
            comboFiltros.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelecionarImagemClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Selecione uma imagem";
            dialog.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png|Bitmap Images(*.bmp)|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var sr = new StreamReader(dialog.FileName))
                    _imagemOriginal = (Bitmap)Image.FromStream(sr.BaseStream);

                _imagemNormalizada = _imagemOriginal.Copiar(pictureImagemOriginal.Width);
                pictureImagemOriginal.Image = _imagemNormalizada;
            }

            Executar();
        }

        private void Executar()
        {
            if (_imagemOriginal is null) return;

            IFiltro? filtro = default;

            if (comboFiltros.SelectedItem is IFiltro item) 
                filtro = item;

            _imagemFinal = filtro?.Aplicar(_imagemNormalizada);
            pictureImagemFinal.Image = _imagemFinal;
        }

        private void ComboFiltros_SelectedIndexChanged(object sender, EventArgs e) => Executar();

        private void BtnSalvarImagem_Click(object sender, EventArgs e)
        {
            if (_imagemFinal != null)
            {
                var janela = new SaveFileDialog();
                janela.Title = "Selecione o local e o formato do arquivo";
                janela.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg|Bitmap Images(*.bmp)|*.bmp";

                if (janela.ShowDialog() == DialogResult.OK)
                {
                    string extensao = Path.GetExtension(janela.FileName).ToUpper();
                    var formatoImagem = ObterFormatoImagem(extensao);                    

                    StreamWriter sw = new StreamWriter(janela.FileName, false);
                    _imagemFinal?.Save(sw.BaseStream, formatoImagem);

                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private ImageFormat ObterFormatoImagem(string extensao)
        {
            switch (extensao)
            {
                case ".PNG":
                    return ImageFormat.Png;

                case ".JPG":
                    return ImageFormat.Jpeg;

                default:
                    return ImageFormat.Bmp;
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureImagemFinal_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}