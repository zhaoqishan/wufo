using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace fuwo.EntityFrameworkCore
{
    public static class fuwoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<fuwoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<fuwoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
