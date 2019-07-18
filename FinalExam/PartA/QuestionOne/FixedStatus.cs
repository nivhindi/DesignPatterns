namespace FinalTest.QuestionOne
{
    internal class FixedStatus : ShipStatusBase
    {
        public FixedStatus(Context ctx) : base(ctx)
        {
        }

        public override string getShipStatus()
        {
            return "Fixed";
        }
    }
}