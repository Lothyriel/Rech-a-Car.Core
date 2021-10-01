using NLog;

namespace Infra.NLogger
{
    public class NLogger
    {
        public static Logger Logger => LogManager.GetCurrentClassLogger();
        static NLogger()
        {
            var configuration = new NLog.Config.LoggingConfiguration();
            var seq = new NLog.Targets.Seq.SeqTarget() { ServerUrl = "http://rechacar.brazilsouth.cloudapp.azure.com:5341", ApiKey = "l8TKEZzOmHxQ9F6qOT2R" };
            configuration.AddRule(LogLevel.Debug, LogLevel.Fatal, seq);
            LogManager.Configuration = configuration;
        }
    }
}
