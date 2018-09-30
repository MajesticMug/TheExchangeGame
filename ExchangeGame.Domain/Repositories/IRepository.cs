using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Base;

namespace ExchangeGame.Domain.Repositories
{
    public interface IRepository<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> GetAll();
        Task<ICollection<TModel>> GetAllAsync();
        Task<TModel> GetById(int id);
        Task Create(TModel model);
        Task Update(int id, TModel model);
        Task Delete(int id);
    }
}