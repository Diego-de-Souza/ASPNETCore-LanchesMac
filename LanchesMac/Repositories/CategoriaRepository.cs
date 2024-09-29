using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        //injeção da vadiavel AppDbContext no contrutor, ou seja injetando uma instancia de context no construtor
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        //define a assinatura da propriedade categoria
        public IEnumerable<Categoria> categorias => _context.Categorias;
    }
}
