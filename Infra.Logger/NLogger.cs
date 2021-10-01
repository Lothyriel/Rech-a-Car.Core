using NLog;

namespace Infra.NLogger
{
    public class NLogger
    {
        public readonly static Logger Logger = LogManager.GetCurrentClassLogger();
        static NLogger()
        {
            var configuration = new NLog.Config.LoggingConfiguration();
            var seq = new NLog.Targets.Seq.SeqTarget() { ServerUrl= "http://rechacar.brazilsouth.cloudapp.azure.com:5341" };
            configuration.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, seq);

            LogManager.Configuration = configuration;
        }        
    }
}
