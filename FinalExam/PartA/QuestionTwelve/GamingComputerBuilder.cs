using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTwelve
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("Gaming computercase");
        }

        public override void AddCPU()
        {
            computer.AddCPU("Gaming CPU");
        }

        public override void AddGPU()
        {
            computer.AddGPU("Gaming GPU");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("Gaming motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("Gaming RAM");
        }
    }
}
