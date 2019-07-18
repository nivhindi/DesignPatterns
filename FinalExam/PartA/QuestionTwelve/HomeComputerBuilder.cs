using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTwelve
{
    public class HomeComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("Home computercase");
        }

        public override void AddCPU()
        {
            computer.AddCPU("Home CPU");
        }

        public override void AddGPU()
        {
            computer.AddGPU("Home GPU");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("Home motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("Home RAM");
        }
    }
}
