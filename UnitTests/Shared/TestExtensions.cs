using Infra.NLogger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Shared
{
    public class TestExtensions
    {
        [AssemblyInitialize]
        public static void ConfigurarLog()
        {
            NLogger.Logger.Factory.CreateNullLogger();
        }
    }
}
