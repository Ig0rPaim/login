using Microsoft.EntityFrameworkCore;
using LoginAPI.Models;
using Flunt.Notifications;

namespace LoginAPI.Data
{
    public class AplicationDbContextUser : DbContext
    {
        public DbSet<UserModel> User1 { get; set; }

        public AplicationDbContextUser(DbContextOptions<AplicationDbContextUser> context) : base(context)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DatabaseUser"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();
            modelBuilder.Entity<UserModel>().HasData(new UserModel
            {
                Id = 1,
                Nome = "Igor Paim de Oliveira",
                BytePassword = Criptografia.Criptografy.getInByteArray("password"),
                Phone = Criptografia.CripitografiaEmailEtc.Criptografar("71999434958"),
                Email = Criptografia.CripitografiaEmailEtc.Criptografar("igorpaimdeoliveira@gmail.com"),
                DataCadastro = DateTime.Now,
                Role = "manager"

            });

            modelBuilder.Entity<UserModel>().HasData(new UserModel
            {
                Id = 2,
                Nome = "Rogerio Oliveira",
                BytePassword = Criptografia.Criptografy.getInByteArray("password"),
                Phone = Criptografia.CripitografiaEmailEtc.Criptografar("71999434958"),
                Email = Criptografia.CripitografiaEmailEtc.Criptografar("Rogeriodeoliveira@gmail.com"),
                DataCadastro = DateTime.Now,
                Role = "client"

            });

            modelBuilder.Entity<UserModel>().HasData(new UserModel
            {
                Id = 3,
                Nome = "Magno Paim",
                BytePassword = Criptografia.Criptografy.getInByteArray("password"),
                Phone = Criptografia.CripitografiaEmailEtc.Criptografar("71999434958"),
                Email = Criptografia.CripitografiaEmailEtc.Criptografar("Magnopaim@gmail.com"),
                DataCadastro = DateTime.Now,
                Role = "client"

            });
        }
    }
}
