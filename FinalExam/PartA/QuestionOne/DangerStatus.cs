using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionOne
{
    public class DangerStatus : ShipStatusBase
    {
        public DangerStatus(Context ctx) : base(ctx)
        {
        }

        public override string getShipStatus()
        {
            return "Danger";
        }
    }
}
