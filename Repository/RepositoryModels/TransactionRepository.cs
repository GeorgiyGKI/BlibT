using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.RepositoryModels.GenreRepository;
using RepositoryInterfaces.RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Transaction> GetTransactionAsync(int genreId, bool trackChanges) =>
               await FindByCondition(Entity => Entity.Id.Equals(genreId), trackChanges).SingleOrDefaultAsync();

        public void CreateTransaction(Transaction genre) => Create(genre);

        public void DeleteTransaction(Transaction genre) => Delete(genre);
    }
}
