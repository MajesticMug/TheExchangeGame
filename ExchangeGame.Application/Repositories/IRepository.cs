using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Domain.Model.Markups;

namespace ExchangeGame.Application.Repositories
{
    public interface IRepository<TModel> where TModel : BaseModel, IAggregateRoot
    {
        IQueryable<TModel> GetAll();
        Task<ICollection<TModel>> GetAllAsync();
        Task<TModel> GetById(int id);
        Task<int> Create(TModel model);
        Task Update(int id, TModel model);
        Task DeleteAsync(int id);
    }
}