using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites.Wallet
{
    public class Wallet : BaseEntity
    {
        public string UserId{ get; set; }
        public int Balance{ get; set; }
        public virtual ICollection<WalletsReceivesTransaction> WalletsReceivesTransactions{ get; set; }
        public virtual ICollection<WalletsPaymentsTransaction> WalletsPaymentsTransactions { get; set; }


    }
}
