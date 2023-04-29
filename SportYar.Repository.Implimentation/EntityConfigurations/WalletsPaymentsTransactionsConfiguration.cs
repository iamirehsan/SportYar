using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class WalletsPaymentsTransactionsConfiguration : BaseEntityConfiguration<WalletsPaymentsTransaction>
    {
        public void Configure(EntityTypeBuilder<WalletsPaymentsTransaction> builder)
        {
         
        }
    }
}
