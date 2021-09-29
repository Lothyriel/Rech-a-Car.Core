using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
