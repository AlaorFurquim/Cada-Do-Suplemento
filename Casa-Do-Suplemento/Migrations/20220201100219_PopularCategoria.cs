using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casa_Do_Suplemento.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)"
                + "VALUES('Whey Protein ' , 'Suplementos com Proteina Isolada')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)"
                + "VALUES('Creatina ' ,' A creatina é a combinação de 3 aminoácidos: glicina, arginina e metionina.')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)"
               + "VALUES('Termogenico ', 'suplemento Termogênico é também conhecido como queimador de gordura')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao)"
               + "VALUES('BCAA ', ' suplemento alimentar que ajuda no ganho de massa muscular com aminoacidos leucina, isoleucina e valina')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
