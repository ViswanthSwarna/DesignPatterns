using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Classes
{
    public class YellowStatus : State
    {
        public YellowStatus(ITrafficLight trafficLight) : base(trafficLight)
        {
        }

        public override void ChangeColor()
        {
            trafficLight.SetStatus(new RedStatus(trafficLight));
        }
    }
}
