using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Infrastructure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(params string[] args)
        {
            //const string serverName = ".";
            const string serverName = "(localdb)\\.";

            const string connectionString = "Server=" + serverName + @";Database=aspnet-Travel-00000000-0000-0000-0000-000000000000;Trusted_Connection=True;MultipleActiveResultSets=true";

            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            if (args.Contains("UseInMemoryDatabase"))
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "Test");
            }
            else
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
