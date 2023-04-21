using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Implimentation.EntityConfigurations;

namespace SportYar.Repository.Implimentation
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Announcement> Regions { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WalletsReceivesTransaction> WalletsReceivesTransactions { get; set; }
        public DbSet<WalletsPaymentsTransaction> WalletsPaymentsTransactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new WalletsConfiguration());
            modelBuilder.ApplyConfiguration(new WalletsPaymentsTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new WalletsReceivesTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new RequestsConfigurations());
            modelBuilder.ApplyConfiguration(new AnnouncementsConfiguration());
            modelBuilder.ApplyConfiguration(new RegionsConfiguration());
 

        }
    }
}
