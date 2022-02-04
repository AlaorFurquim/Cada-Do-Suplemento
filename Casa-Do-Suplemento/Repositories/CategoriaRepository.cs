using Casa_Do_Suplemento.Context;
using Casa_Do_Suplemento.Models;
using Casa_Do_Suplemento.Repositories.Interfaces;

namespace Casa_Do_Suplemento.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
            
    }
}
