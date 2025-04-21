using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Classes
{
    public abstract class State
    {
        public ITrafficLight trafficLight;

        public State(ITrafficLight trafficLight) 
        {
            this.trafficLight = trafficLight;
        }

        public abstract void ChangeColor();

    }
}
