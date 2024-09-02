using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{ 
    /* Classe usada para interagir com o banco de dados em uma aplicação ASP.NEt COre
     utilizando o Entity Framework COre*/
    public class AppDbContext: DbContext //Esta é a classe que representa o contexto de banco de dados da aplicação
    {
        /* AppDbContext herda de DbContext, que é a classe base do Entity Framework Core 
         * que representa uma sessão com o banco de dados e é usada para consultar e 
         * salvar dados no banco de dados.*/
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        /*Este é o construtor da classe AppDbContext. Ele recebe um parâmetro options do tipo 
         * DbContextOptions<AppDbContext>, que contém as opções de configuração do contexto, 
         * como a string de conexão e outros detalhes de configuração.
         : base(options): Chama o construtor da classe base (DbContext) passando options para ele. 
        Isso é necessário para que o DbContext possa ser configurado corretamente com as opções fornecidas.*/

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        /*Representa a tabela Categorias no banco de dados e permite realizar 
         * operações CRUD (Criar, Ler, Atualizar, Deletar) na tabela*/
    }
}
