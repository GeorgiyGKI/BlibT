using Shared.DataTransferObjects;

namespace Services.ServiceInterfaces
{
    public interface ITransactionService
    {
        Task CreateTransactionAsync(TransactionDto transactionDto);
        Task<IEnumerable<TransactionDto>> GetAllTransactionsAsync();
    }
}