using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Singleton s3 = Singleton.GetInstance();
            s1.printCurrentTime();
            s2.printCurrentTime();
            s3.printCurrentTime();
        }
    }
}
