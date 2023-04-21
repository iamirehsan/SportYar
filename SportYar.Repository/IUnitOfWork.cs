using SportYar.Repository.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace SportYar.Repository
{
    public interface IUnitOfWork
    {
        public IWalletsRepository WalletsRepository { get;   }
        public IWalletsReceivesTransactionsRepository WalletsReceivesTransactionsRepository { get;   }
        public IWalletsPaymentsTransactionsRepository WalletsPaymentsTransactionsRepository { get; }
        public IRegionsRepository RegionsRepository { get; }
        public IAnnouncementsRepository AnnouncementsRepository { get; }
        public IRequestsRepository RequestsRepository { get; }
   


    }
}
