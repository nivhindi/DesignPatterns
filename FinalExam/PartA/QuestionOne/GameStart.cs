namespace FinalTest.QuestionOne
{
    internal class GameStart : GameStatusBase
    {
        private int steps;

        public GameStart(Context ctx) : base(ctx)
        {
            this.steps = 1;
        }

        public override void NextState(ShipStatusBase shipStatusBase)
        {
            this.ctx.shipState = shipStatusBase;
            if (steps == 3 && this.ctx.shipState.getShipStatus() == "Fixed")
            {
                this.ctx.gameState = new Win(this.ctx);
            }
            else if(this.ctx.shipState.getShipStatus() == "Danger")
            {
                this.ctx.gameState = new Lose(this.ctx);
            }
            else
            {
                this.steps++;
            }
        }
    }
}