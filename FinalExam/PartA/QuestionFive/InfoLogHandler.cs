using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.QuestionFive
{
    class InfoLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            Console.WriteLine(level.ToString() + " | message is: " + message);
            if (level < LogLevel.Info && next != null)
                next.Log(message, level);
        }
    }
}
