using Casa_Do_Suplemento.Context;
using Casa_Do_Suplemento.Models;
using Microsoft.EntityFrameworkCore;

namespace Casa_Do_Suplemento.Repositories
{
    public class SuplementoRepository
    {
        private readonly AppDbContext _context;

        public SuplementoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Suplemento> Suplementos => _context.Suplementos.Include(C => C.Categoria);

        public IEnumerable<Suplemento> SuplementosPreferidos =>
        _context.Suplementos.Where(p => p.IsSuplementoFavorito).Include(C => C.Categoria);

        public Suplemento GetSuplementoById(int suplementoId) => _context.Suplementos.FirstOrDefault(I => I.SuplementoId == suplementoId);

    }
}
