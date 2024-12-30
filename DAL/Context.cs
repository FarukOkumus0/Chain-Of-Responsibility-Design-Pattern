using Microsoft.EntityFrameworkCore;

namespace DesingPattern.ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1UNVJO1\\SQLEXPRESS01;initial catalog=DesignPattern1;integrated security=true;TrustServerCertificate=true;");
            //TrustServerCertificate=true eklendi
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
