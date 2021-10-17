namespace Infra.Extensions.Methods
{
    static class TestExtensions
    {
        public static string SqlResetId(string tableName)
        {
            return $@"DELETE FROM {tableName} DBCC CHECKIDENT('[{tableName}]', RESEED, 0)";
        }
    }
}
