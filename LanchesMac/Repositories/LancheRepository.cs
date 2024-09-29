using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        //injetando uma instancia de DB context
        private readonly AppDbContext _context;
        //criando o construtor e passando a instancia para a variavel
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LcahePreferido => _context.Lanches.Where(l => l.IsLanchePreferido).Include(c=> c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l =>  l.LancheId == lancheId);
        }
    }
}
