using Microsoft.EntityFrameworkCore;

namespace Casgem_ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4FNRCPJ\\SQLEXPRESS;initial Catalog=CasgemDbCoR;integrated Security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesss { get; set; }
    }
}
