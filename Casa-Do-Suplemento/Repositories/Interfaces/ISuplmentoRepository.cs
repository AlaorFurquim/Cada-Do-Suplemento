using Casa_Do_Suplemento.Models;

namespace Casa_Do_Suplemento.Repositories.Interfaces
{
    public interface ISuplmentoRepository
    {
        IEnumerable<Suplemento> Suplementos { get; }
        IEnumerable<Suplemento> SuplementosPreferidos { get; }
        Suplemento GetSuplementoById(int suplementoId);
    }
}
