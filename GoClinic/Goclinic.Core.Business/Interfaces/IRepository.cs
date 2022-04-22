using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Goclinic.Agendamento.Business.Interfaces
{
   public  interface IRepository
    {
        public interface IRepository<TEntity> 
        {
            Task Adicionar(TEntity entity);
            Task<TEntity> ObterPorId(object id);
            Task<List<TEntity>> ObterTodos();
            Task Atualizar(int id);
            Task Remover(int id);
            Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
            Task<int> SaveChanges();
        }
    }
}
