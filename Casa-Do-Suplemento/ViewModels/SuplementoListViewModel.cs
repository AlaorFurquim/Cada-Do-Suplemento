using Casa_Do_Suplemento.Models;

namespace Casa_Do_Suplemento.ViewModels
{
    public class SuplementoListViewModel
    {
        public IEnumerable<Suplemento> Suplemento { get; set; }

        public string CategoriaAtual { get; set; }
    }
}
