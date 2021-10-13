using ConfigurationManager;
using NLog;

namespace Infra.NLogger
{
    public class NLogger
    {
        public static Logger Logger => LogManager.GetCurrentClassLogger();
        static NLogger()
        {
            var apiKey = AppConfigManager.AppConfig["SeqApiKey"].ToString();

            var configuration = new NLog.Config.LoggingConfiguration();
            var seq = new NLog.Targets.Seq.SeqTarget() { ServerUrl = "http://rechacar.brazilsouth.cloudapp.azure.com:5341", ApiKey = apiKey };
            var debug = new NLog.Targets.DebuggerTarget();
            configuration.AddRuleForAllLevels(debug);
            configuration.AddRuleForAllLevels(seq);
            LogManager.Configuration = configuration;
        }
    }
}
