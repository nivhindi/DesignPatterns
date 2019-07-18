using System;

namespace FinalTest.QuestionOne
{
    public class Context
    {
        public IGameState gameState { get; set; }
        public IShipState shipState { get; set; }

        public Context()
        {

        }

        public void Init(IGameState state)
        {
            this.gameState = state;
        }
    }
}