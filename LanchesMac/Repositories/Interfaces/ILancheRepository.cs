using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        //obtem uma lista de lanches
        IEnumerable<Lanche> Lanches { get; }
        //obtendo uma lista de lanche com filtro
        IEnumerable<Lanche> LcahePreferido { get; }
        //obtendo uma lista de lanhe pelo ID
        Lanche GetLancheById(int lancheId);
    }
}
