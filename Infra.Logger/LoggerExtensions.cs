using NLog;
using System.IO;
using System.Runtime.CompilerServices;

namespace Infra.NLogger
{
    public static class LoggerExtensions
    {
        public static Logger Aqui(
            this Logger logger,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            return logger
                .WithProperty("MemberName", memberName)
                .WithProperty("ClassName", Path.GetFileNameWithoutExtension(sourceFilePath))
                .WithProperty("LineNumber", sourceLineNumber);
        }
    }
}
