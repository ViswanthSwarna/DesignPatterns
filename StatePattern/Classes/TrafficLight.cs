using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Classes
{
    public class TrafficLight : ITrafficLight
    {
        private State state;

        public TrafficLight()
        {
            state = new YellowStatus(this);
        }
        public State SetStatus(State state)
        {
            this.state = state;
            return this.state;
        }

        public void MakeNoise() 
        {
            Console.WriteLine($"Make Noise {state.ToString()}");
        }

        public void ChangeColor() 
        {
            this.state.ChangeColor();
        }
    }
}
