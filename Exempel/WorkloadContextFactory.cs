namespace Exempel
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class WorkloadContextFactory : IDesignTimeDbContextFactory<WorkloadsDb>
    {
        private static readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WorkloadsTest;Integrated Security=True;";
        //public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        public WorkloadsDb CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<WorkloadsDb> optionsBuilder = new DbContextOptionsBuilder<WorkloadsDb>();
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLoggerFactory(MyLoggerFactory);

            //return new WorkloadsDb(optionsBuilder.Options, MyLoggerFactory);
            return new WorkloadsDb(optionsBuilder.Options);
        }
    }
}
