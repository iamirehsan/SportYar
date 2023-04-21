using Microsoft.EntityFrameworkCore;
using SportYar.Repository.Implimentation;
using SportYar.Repository.Implimentation.Implementations;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation
{
    public class UnitOfWork : IUnitOfWork
    {
        private WalletsRepository _walletsRepository;
        private WalletsReceivesTransactionsRepository _walletsReceivesTransactionsRepository;
        private WalletsPaymentsTransactionsRepository _walletsPaymentsTransactionsRepository;
        private RequestsRepository _requestsRepository;
        private AnnouncementsRepository _announcementsRepository;
        private RegionsRepository _regionsRepository;

        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IWalletsRepository WalletsRepository => _walletsRepository = _walletsRepository ?? new WalletsRepository(_context);

        public IWalletsReceivesTransactionsRepository WalletsReceivesTransactionsRepository => _walletsReceivesTransactionsRepository = _walletsReceivesTransactionsRepository ?? new WalletsReceivesTransactionsRepository(_context);

        public IWalletsPaymentsTransactionsRepository WalletsPaymentsTransactionsRepository => _walletsPaymentsTransactionsRepository = _walletsPaymentsTransactionsRepository ?? new Implementations.WalletsPaymentsTransactionsRepository(_context);

        public IRegionsRepository RegionsRepository => _regionsRepository = _regionsRepository ?? new RegionsRepository(_context);

        public IAnnouncementsRepository AnnouncementsRepository => _announcementsRepository = _announcementsRepository ?? new AnnouncementsRepository(_context) ;

        public IRequestsRepository RequestsRepository => _requestsRepository = _requestsRepository ?? new Implementations.RequestsRepository(_context);
 
    }
}

