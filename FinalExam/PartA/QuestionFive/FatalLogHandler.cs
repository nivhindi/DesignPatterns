using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.QuestionFive
{
    public class FatalLogHandler : LogHandler
    {
        public override void Log(string message, LogLevel level)
        {
            Console.WriteLine("Writing to array, file and sending SMS to the admin");
            if (level < LogLevel.Fatal && next != null)
                next.Log(message, level);
        }
    }
}
