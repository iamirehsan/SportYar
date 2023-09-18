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
        private CitiesRepository _citiesRepository;
        private ProvincesRepository _provincesRepository;
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

        public ICitiesRepository CitiesRepository => _citiesRepository=_citiesRepository ?? new CitiesRepository(_context);

        public IProvincesRepository ProvincesRepository => _provincesRepository = _provincesRepository ?? new ProvincesRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
             await _context.SaveChangesAsync();
        }
    }
}

