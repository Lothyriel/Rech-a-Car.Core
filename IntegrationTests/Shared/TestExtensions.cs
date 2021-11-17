using Infra.DAO.ORM;
using System.Linq;

namespace IntegrationTests.Shared
{
    static class TestExtensions
    {
        public static string ResetId(string tableName)
        {
            return $@"DELETE FROM {tableName} DBCC CHECKIDENT('[{tableName}]', RESEED, 0)";
        }

        public static void DeleteAll<T>(this Rech_a_carDbContext ctx) where T : class
        {
            var todos = ctx.Set<T>().ToList();
            ctx.Set<T>().RemoveRange(todos);
            ctx.SaveChanges();
        }
    }
}
