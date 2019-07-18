using System;
using System.Collections.Generic;
using System.Text;

namespace Test.QuestionThree
{
    public class Car : ICar, IMonitorable
    {
        public void GetPosition()
        {
            Console.WriteLine("This is the position");
        }

        public void GetTankStatus()
        {
            Console.WriteLine("Tank status");
        }

        public void Left()
        {
            Console.WriteLine("Turn left");
        }

        public void Right()
        {
            Console.WriteLine("Turn right");
        }

        public void SpeedDown()
        {
            Console.WriteLine("Slow");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Fast");
        }

        public void Start()
        {
            Console.WriteLine("Gas");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
