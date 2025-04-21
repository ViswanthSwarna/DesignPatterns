using FlyWeightPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Classes
{
    public class AnimeCharacterFlyWeightFactory : IAnimeCharacterFlyWeightFactory
    {
        private Dictionary<string, IAnimeCharacter> animeCharacterObjects = new Dictionary<string, IAnimeCharacter>();
        public IAnimeCharacter CreateAnimeCharacter(string id, string details)
        {
            IAnimeCharacter animeCharacter = null;
            if (animeCharacterObjects.ContainsKey(id)) 
            {
                animeCharacter = animeCharacterObjects.GetValueOrDefault(id);
            }
            else 
            {
                animeCharacter = new AnimeCharacter(details, id);
                animeCharacterObjects.Add(id, animeCharacter);
            }
            return animeCharacter;
        }
    }
}
