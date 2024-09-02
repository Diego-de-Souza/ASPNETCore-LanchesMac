using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /*******************************************************
     * Migration modelo de população de tabela, para processo
     inicial de aprendizado de como criar uma migratios para 
    popular inicialmente sua tabela no mysql
    ********************************************************/
    public partial class PopularCagetorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao) " +
                            "VALUES('normal','Lanche feito com ingredientes normais.')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,CategoriaDescricao) " +
                            "VALUES('natural','Lanche feito com ingredientes naturais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE from Categorias");
        }
    }
}
