using LanchesMac.Models;
using System.Data.SqlTypes;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //define o contrato com a classe que é implementado com a classe context
        IEnumerable<Categoria> categorias {  get; }
    }
}
