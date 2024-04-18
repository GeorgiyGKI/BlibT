using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryInterfaces.RepositoryModels
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync(bool trackChanges);
        Task<Transaction> GetTransactionAsync(int id, bool trackChanges);
        void CreateTransaction(Transaction genre);
        void DeleteTransaction(Transaction genre);
    }
}
