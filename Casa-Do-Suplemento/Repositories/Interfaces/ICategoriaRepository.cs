using Casa_Do_Suplemento.Models;

namespace Casa_Do_Suplemento.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
