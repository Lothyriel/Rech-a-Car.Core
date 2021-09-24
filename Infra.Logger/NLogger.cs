using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.NLogger
{
    public class NLogger
    {
        public readonly static Logger Logger = LogManager.GetCurrentClassLogger();
    }
}
