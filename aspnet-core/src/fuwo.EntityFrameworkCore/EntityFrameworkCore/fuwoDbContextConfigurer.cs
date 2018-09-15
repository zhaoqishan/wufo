using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace fuwo.EntityFrameworkCore
{
    public static class fuwoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<fuwoDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<fuwoDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
