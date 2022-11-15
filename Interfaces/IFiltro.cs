namespace Filtros.Interfaces
{
    public interface IFiltro
    {
        public string NomeFiltro { get; }

        public Bitmap Aplicar(Bitmap imagemOriginal);
    }
}
