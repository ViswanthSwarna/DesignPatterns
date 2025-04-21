using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Interfaces
{
    public interface IAnimeCharacterFlyWeightFactory
    {
        IAnimeCharacter CreateAnimeCharacter(string id, string details);
    }
}
