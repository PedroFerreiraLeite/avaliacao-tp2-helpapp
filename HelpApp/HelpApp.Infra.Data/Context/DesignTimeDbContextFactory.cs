using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HelpApp.Infra.Data.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source=PEDRO_F_LEITE\\SQLEXPRESS01;Initial Catalog=avaliacao_tp2_pedroleite;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
