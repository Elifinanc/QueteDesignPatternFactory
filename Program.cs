using System;
using System.Collections.Generic;
using System.Linq;

namespace QueteDesignPatternFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            List<string> caractere = new List<string>(){ "Vénal", "Indécis", "Fou", "Végétarien", "Profiteur", "Psychopathe", "Xénophobe" };
            Console.WriteLine("Write your future President character : ");
            string currentCharacter = Console.ReadLine();
            while (!caractere.Contains(currentCharacter))
            {
                Console.WriteLine("Write your future President character : ");
                currentCharacter = Console.ReadLine();
            }
            President newPresident = PresidentFactory.Create(currentCharacter);
            Console.WriteLine(newPresident.Slogan);
        }
    }
}
