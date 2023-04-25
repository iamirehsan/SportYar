using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
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
        public DbSet<Region> Regions { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WalletsReceivesTransaction> WalletsReceivesTransactions { get; set; }
        public DbSet<WalletsPaymentsTransaction> WalletsPaymentsTransactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces{ get; set; }

        public  void SeedDataFromExcel<T>(string filePath , Dictionary<string,int> ExcelHeader) where T : class
        {
            using var package = new ExcelPackage(new FileInfo(filePath));
            var worksheet = package.Workbook.Worksheets[typeof(T).Name];
            var rows = worksheet.Dimension.Rows;

            var entityType = typeof(T);
            var properties = entityType.GetProperties()
                .Where(p => p.CanWrite && !p.GetGetMethod().IsVirtual);

            for (int row = 2; row <= rows; row++)
            {
                var entity = Activator.CreateInstance<T>();

                foreach (var property in properties)
                {
                    var cellValue = worksheet.Cells[row, ExcelHeader[property.Name]].Value;
                    if (cellValue != null)
                    {
                        var convertedValue = Convert.ChangeType(cellValue, property.PropertyType);
                        property.SetValue(entity, convertedValue);
                    }
                }

                Set<T>().Add(entity);
            }

              SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new WalletsConfiguration());
            //modelBuilder.ApplyConfiguration(new WalletsPaymentsTransactionsConfiguration());
            //modelBuilder.ApplyConfiguration(new WalletsReceivesTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new RequestsConfigurations());
            modelBuilder.ApplyConfiguration(new AnnouncementsConfiguration());
            modelBuilder.ApplyConfiguration(new RegionsConfiguration());
            modelBuilder.ApplyConfiguration(new CitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ProvincesConfiguration());


        }
    }
}
