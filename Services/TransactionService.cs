using AutoMapper;
using Contracts;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.ServiceManager;
using Services.ServiceInterfaces;
using Shared.DataTransferObject;
using Shared.DataTransferObjects;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repository;
        public TransactionService(IRepositoryManager repository,
            ILoggerManager logger,
            IMapper mapper)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _repository = repository;
        }

        public async Task CreateTransactionAsync(TransactionDto transactionDto)
        {
            var transaction = _mapper.Map<Transaction>(transactionDto);
            transaction.Books = [];
            foreach (var buyedBookDto in transactionDto.Books)
                transaction.BookTransactions.Add(new BookTransaction { BookId = (int)buyedBookDto.Id });

            _repository.Transaction.CreateTransaction(transaction);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<TransactionDto>> GetAllTransactionsAsync()
        {
            var transactions = await _repository.Transaction.GetAllTransactionsAsync(false);
            var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactions);

            return transactionsDto;
        }
    }
}
