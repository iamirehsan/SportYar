using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites.Wallet
{
    public class WalletsPaymentsTransaction : BaseEntity
    {
        public string WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
        public string PaymentId { get; set; }
        public int Balance { get; set; }

       
    }
}
