using Microsoft.EntityFrameworkCore;
using QuickMedik.Model;

namespace QuickMedik.Data

{
    public class DataBaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Proffesional> Proffesionals { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Clients");
            optionsBuilder.UseInMemoryDatabase(databaseName: "Proffesionals");

        }
        /* public DbSet<OrderModel> Orders { get; set; }

         public DataBaseContext(DbContextOptions<OrderDbContext> options) : base(options)
         {
         }
         protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseInMemoryDatabase(databaseName: "OrdersDb");
         }*/



    }
}
