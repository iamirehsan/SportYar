using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites.Wallet
{
    public class WalletsReceivesTransaction : BaseEntity
    {
        public int Balance { get; set; }
        public string WalletId { get; set; }
        public Wallet Wallet { get; set; }

    }
}
