using System.Linq;

namespace FightArena 
{
    public class EgonTheMoose : Heroes
    {
        private string name = "Egon The Moose";

        public string Name
        {
            get => name;
            set => name = value;
        }
        
        //Heroes heroes = new Heroes(Enumerable.Range(5, 11), Enumerable.Range(4, 4),90 );
    }
}