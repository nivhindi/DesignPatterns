using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTwelve
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer GetComputer()
        {
            if (computer == null)
                throw new Exception("The computer was not built yet");

            return computer;
        }

        public void BuildComputer()
        {
            this.computer = new Computer();
            AddComputerCase();
            AddMotherBoard();
            AddCPU();
            AddGPU();
            AddRAM();
            RunCheck();
        }

        public abstract void AddComputerCase();
        public abstract void AddMotherBoard();

        public abstract void AddCPU();

        public abstract void AddGPU();

        public abstract void AddRAM();

        public void RunCheck()
        {
            computer.RunCheck();
        }
    }
}
