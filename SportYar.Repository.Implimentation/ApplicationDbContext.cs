using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using SportYar.Domain.Entites;
using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Implimentation.EntityConfigurations;
using System.Reflection;
using System.Security;

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
            var buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var aa = buildDir + @"\Seed\Province.xlsx";
            XLWorkbook bb = new(filePath);
    
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "YourProjectName.ExcelFileName.xlsx"; // Replace with your Excel file name and path
            var stream = assembly.GetManifestResourceStream(resourceName);
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.First();
                var rows = worksheet.Dimension.Rows;
                var entityType = typeof(T);
                var properties = entityType.GetProperties()
                    .Where(p => p.CanWrite && !p.GetGetMethod().IsVirtual);
                var headerAndPropertiesIntersection = properties.Where(c => ExcelHeader.Keys.Contains(c.Name));

                for (int row = 2; row <= rows; row++)
                {
                    var entity = Activator.CreateInstance<T>();

                    foreach (var property in headerAndPropertiesIntersection)
                    {
                        var cellValue = worksheet.Cells[row, ExcelHeader[property.Name]].Value;

                        if (cellValue != null)
                        {
                            cellValue = cellValue.ToString().Replace("ك", "ک");
                            cellValue = cellValue.ToString().Replace("ي", "ی");
                            var convertedValue = Convert.ChangeType(cellValue, property.PropertyType);
                            property.SetValue(entity, convertedValue);

                        }
                    }

                    Set<T>().Add(entity);
                }


            }

           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new WalletsConfiguration());
            modelBuilder.ApplyConfiguration(new WalletsPaymentsTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new WalletsReceivesTransactionsConfiguration());
            modelBuilder.ApplyConfiguration(new RequestsConfigurations());
            modelBuilder.ApplyConfiguration(new AnnouncementsConfiguration());
            modelBuilder.ApplyConfiguration(new RegionsConfiguration());
            modelBuilder.ApplyConfiguration(new CitiesConfiguration());
            modelBuilder.ApplyConfiguration(new ProvincesConfiguration());

        }
    }
}
