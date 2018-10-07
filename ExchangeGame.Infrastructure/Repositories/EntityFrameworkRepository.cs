using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeGame.Domain.Model.Base;
using ExchangeGame.Application.Repositories;
using ExchangeGame.Domain.Model.Markups;
using Microsoft.EntityFrameworkCore;

namespace ExchangeGame.Infrastructure.Repositories
{
    public class EntityFrameworkRepository<TModel> : IRepository<TModel>
        where TModel : BaseModel, IAggregateRoot
    {
        private readonly ExchangeGameDbContext _dbContext;

        public EntityFrameworkRepository(ExchangeGameDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TModel> GetAll()
        {
            return _dbContext.Set<TModel>();
        }

        public async Task<ICollection<TModel>> GetAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<TModel> GetById(int id)
        {
            return await _dbContext.Set<TModel>()
                .Where(model => model.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task Create(TModel model)
        {
            await _dbContext.Set<TModel>().AddAsync(model);

            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, TModel model)
        {
            _dbContext.Set<TModel>().Update(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var toDelete = await GetById(id);
            _dbContext.Set<TModel>().Remove(toDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}