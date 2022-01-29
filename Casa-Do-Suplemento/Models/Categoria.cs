namespace Casa_Do_Suplemento.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string CategoriaName { get; set; }

        public string Descricao { get; set; }

        public List<Suplemento> Suplementos { get; set; } //relacionamento de um para muito 
        
    }
}
