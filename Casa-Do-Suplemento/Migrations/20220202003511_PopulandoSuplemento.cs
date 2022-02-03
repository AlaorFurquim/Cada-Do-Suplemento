using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Casa_Do_Suplemento.Migrations
{
    public partial class PopulandoSuplemento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
             "VALUES(1, 'Novo Whey sabor Banana com Chia, além do sabor delicioso da banana ele conta com as propriedades digestivas da Chia' , 'Contém proteína de altíssima qualidade e procedência: Glanbia Nutritionals. Produzida através do método CFM (Cross Flow Microfiltration).' , 10, 'https://www.otimanutri.com.br/produtos_img/gold-whey-900g-banana-caramelizada-nutrata-9872-36290-EG.jpg' , 'https://www.otimanutri.com.br/produtos_img/gold-whey-900g-banana-caramelizada-nutrata-9872-36290-EG.jpg',0,'WHEY PROTEIN BANANA COM CHIA', 99.90)");
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(1, 'Whey Protein Integralmédica fornece 30 g da combinação das melhores proteínas para o ganho de força e massa muscular.' , 'Nutri Whey ainda é fonte de BCAA com o ganho de vitaminas e minerais para uma completa nutrição esportiva.' , 10, 'https://th.bing.com/th/id/OIP.noBVcnEv7i92nHZjaCZpggHaHa?w=215&h=215&c=7&r=0&o=5&pid=1.7' , 'https://th.bing.com/th/id/OIP.noBVcnEv7i92nHZjaCZpggHaHa?w=215&h=215&c=7&r=0&o=5&pid=1.7',0,' Whey Protein Integralmédica Chocolate Nutri - 907g' , 99.99)");
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(1, 'O WAXY WHEY BODYBUILDERS®  é um suplemento proteico em pó para atletas formulado com proteína concentrada do soro do leite.' , 'Possui alto valor biológico e alto teor de aminoácidos essências.A suplementação de proteína potencializa, na maioria das vezes, o aumento e a força dos feixes musculares.' , 10, 'https://static.netshoes.com.br/produtos/whey-protein-iso-protein-2-kg-bodybuilders/62/E56-0303-962/E56-0303-962_zoom1.jpg' , 'https://static.netshoes.com.br/produtos/whey-protein-iso-protein-2-kg-bodybuilders/62/E56-0303-962/E56-0303-962_zoom1.jpg', 0 ,'Waxy Whey Protein Bodybuilders - Baunilha - 2Kg', 75.95)");

            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
             "VALUES(2, 'Ganhe volume e massa muscular, aumente sua força e melhore o desempenho e resistência nos seus treinos suplementando.' , 'Produto 100% puro, de excelente qualidade. A creatina é um nutriente que pode ser produzido pelo nosso próprio organismo, através do consumo de alimentos de origem animal como carnes e peixes.' , 25, 'https://http2.mlstatic.com/creatina-integral-medica-D_NQ_NP_661073-MLB29021441521_122018-F.jpg' , 'https://http2.mlstatic.com/creatina-integral-medica-D_NQ_NP_661073-MLB29021441521_122018-F.jpg' ,0,'100% Pure Creatine 300MG, Integralmedica', 97.90)");
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
             "VALUES(2, 'Creatina pro series (100g) - athletica nutrition é uma combinação de 3 aminoácidos: glicina, arginina e metionina.' , ' creatina monoidratada é a forma de creatina mais estudada no meio cientifico, é um pó branco, fino, que se mistura facilmente em água.' , 15, 'https://th.bing.com/th/id/R.a334216bbd38e2ddcf6c0a4ca604184b?rik=xXykqE2Fxj%2bsOQ&pid=ImgRaw&r=0' , 'https://th.bing.com/th/id/R.a334216bbd38e2ddcf6c0a4ca604184b?rik=xXykqE2Fxj%2bsOQ&pid=ImgRaw&r=0',0,'Creatina 100% Pure (100g), Atlhetica Nutrition', 35.00)");

            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(3, 'O Therma Pro Hardcore da Integralmédica fornece 280 mg de cafeína por dose.' , ' Por ter ação rápida, é uma excelente opção para aumentar a energia e resistência durante os treinos.' , 18, 'https://integralmedica.vteximg.com.br/arquivos/ids/156791-292-292/THERMA_PRO_HARDCORE_60cap.png?v=637324230141300000' , 'https://integralmedica.vteximg.com.br/arquivos/ids/156791-292-292/THERMA_PRO_HARDCORE_60cap.png?v=637324230141300000',0,'Therma Pro Hardcore', 50.37)");
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(3, 'DEXADRINE combina uma poderosa ação termogênica ao favorecimento da saciedade no sistema DUAL ACTION.' , ' A dose diária de DEXADRINE (2 cápsulas) traz 55 mg de gengibre, 55 mg de pimenta e 300 mg de cafeína.' , 15, 'https://http2.mlstatic.com/D_NQ_NP_866997-MLB46706214617_072021-O.webp' , 'https://http2.mlstatic.com/D_NQ_NP_866997-MLB46706214617_072021-O.webp',0,'DEXADRINE ', 74.00)");

            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(4, 'BCAA Age da Nutrilatina é um suplemento alimentar a base de aminoácidos essenciais de cadeia ramificada.' , 'Esses aminoácidos não são produzidos naturalmente pelo corpo e só podem ser adquiridos via alimentação ou suplementação.' , 7, 'https://produto.saudifitness.com.br//1200x1200/10112172409.jpg/flags.jpg?aplicarFlags=true&unidade=1&flagTexto=&v=17' , 'https://produto.saudifitness.com.br//1200x1200/10112172409.jpg/flags.jpg?aplicarFlags=true&unidade=1&flagTexto=&v=17',0,'BCAA AGE ', 50.00)");
            migrationBuilder.Sql("INSERT INTO Suplementos(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsSuplementoFavorito,Nome,Preco)" +
            "VALUES(4, 'BCAA 2044 mg Integralmédica tem fórmula ultraconcentrada composta pelos 3 aminoácidos essenciais: leucina, isoleucina e a valina.' , 'Os BCAAs são aminoácidos utilizados para a construção de massa muscular, recuperação das fibras musculares após treinos intensos e volumosos.' , 15, 'https://integralmedica.vteximg.com.br/arquivos/ids/162496-1000-1000/BCAA-TOP_Produto.png?v=637701739440670000' , 'https://integralmedica.vteximg.com.br/arquivos/ids/162496-1000-1000/BCAA-TOP_Produto.png?v=637701739440670000',0,'BCAA 2044 mg', 45.35)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Suplementos");
        }
    }
}
