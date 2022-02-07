using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextoBase : DbContext
    {
        public ContextoBase(DbContextOptions<ContextoBase> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=192.168.15.144,1433;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=sa;Password=@ndinhu1020;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
