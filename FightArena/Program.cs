using System;

namespace FightArena
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena();

            foreach (var VARIABLE in arena.AllHeroes())
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}