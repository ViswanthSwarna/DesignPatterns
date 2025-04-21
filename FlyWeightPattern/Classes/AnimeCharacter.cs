using FlyWeightPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Classes
{
    public class AnimeCharacter: IAnimeCharacter
    {
        private readonly string CharacterDetails;
        private readonly string CharacterId;
        public AnimeCharacter(string CharacterDetails, string CharacterId)
        {
            this.CharacterDetails = CharacterDetails;
            this.CharacterId = CharacterId;
        }

        public void render(string name)
        {
            Console.WriteLine($"Details: {CharacterDetails}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"Id: {CharacterId}");
        }
    }
}
