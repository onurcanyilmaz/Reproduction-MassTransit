using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Reproduction.EntityFrameworkCore
{
    public static class ReproductionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReproductionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReproductionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
