using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTwelve
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        public override void AddComputerCase()
        {
            computer.AddComputerCase("Office computercase");
        }

        public override void AddCPU()
        {
            computer.AddCPU("Office CPU");
        }

        public override void AddGPU()
        {
            computer.AddGPU("Office GPU");
        }

        public override void AddMotherBoard()
        {
            computer.AddMotherBoard("Office motherboard");
        }

        public override void AddRAM()
        {
            computer.AddRAM("Office RAM");
        }
    }
}
