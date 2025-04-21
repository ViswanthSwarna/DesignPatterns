using StatePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Interfaces
{
    public interface ITrafficLight
    {
        State SetStatus(State state);

        void MakeNoise();

        void ChangeColor();

    }
}
