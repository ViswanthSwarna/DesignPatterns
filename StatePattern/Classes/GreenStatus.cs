using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Classes
{
    public class GreenStatus : State
    {
        public GreenStatus(ITrafficLight trafficLight) : base(trafficLight)
        {
        }

        public override void ChangeColor()
        {
            trafficLight.SetStatus(new YellowStatus(trafficLight));
        }
    }
}
