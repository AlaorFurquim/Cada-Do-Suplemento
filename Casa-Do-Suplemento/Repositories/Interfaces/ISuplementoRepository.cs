using Casa_Do_Suplemento.Models;

namespace Casa_Do_Suplemento.Repositories.Interfaces
{
    public interface ISuplementoRepository
    {
        IEnumerable<Suplemento> Suplementos { get; }
        IEnumerable<Suplemento> SuplementosPreferidos { get; }
        Suplemento GetSuplementoById(int suplementoId);
    }
}
