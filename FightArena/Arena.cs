using System;
using System.Collections.Generic;

namespace FightArena
{
    public class Arena : Heroes
    {
        private Heroes heroe = new Heroes();
        Random rand = new Random();
        public List<Heroes> AllHeroes()
        {
            List<Heroes> allHeroes = new List<Heroes>();
            allHeroes.Add(heroe = new EgonTheMoose());
            allHeroes.Add(heroe = new GunnerPoison());
            allHeroes.Add(heroe = new KarlFast());
            allHeroes.Add(heroe = new KongFuHarry());
            allHeroes.Add(heroe = new MiniMouseMikkel());
            allHeroes.Add(heroe = new RubberGoat());
            allHeroes.Add(heroe = new SuperDogDino());
            allHeroes.Add(heroe = new TigerCat());

            return allHeroes;
        }

        public void FirstFight()
        {

        }

        public void SemiFinal()
        {
            
        }

        public void Final()
        {
            
        }
        
    }
}