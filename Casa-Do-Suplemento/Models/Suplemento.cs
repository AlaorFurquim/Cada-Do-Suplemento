namespace Casa_Do_Suplemento.Models
{
    public class Suplemento
    {
        public int SuplementoId { get; set; }

        public string Nome { get; set; }

        public string DescricaoCurta { get; set; }

        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool IsSuplementoFavorito { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; } // chave estrangeira

        public virtual Categoria Categoria { get; set; } // propriedade de navegacao

    }
}
