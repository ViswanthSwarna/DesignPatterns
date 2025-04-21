


using FlyWeightPattern.Classes;
using FlyWeightPattern.Interfaces;

IAnimeCharacterFlyWeightFactory factory = new AnimeCharacterFlyWeightFactory();


IAnimeCharacter anime1 = factory.CreateAnimeCharacter("1", "HelloWorld1");
IAnimeCharacter anime2 = factory.CreateAnimeCharacter("2", "HelloWorld2");
IAnimeCharacter anime3 = factory.CreateAnimeCharacter("3", "HelloWorld3");
IAnimeCharacter anime4 = factory.CreateAnimeCharacter("2", "HelloWorld2");
IAnimeCharacter anime5 = factory.CreateAnimeCharacter("3", "HelloWorld3");
IAnimeCharacter anime6 = factory.CreateAnimeCharacter("1", "HelloWorld1");

Console.WriteLine(anime1.Equals(anime6));
Console.WriteLine(anime2.Equals(anime4));
Console.WriteLine(anime1.Equals(anime5));