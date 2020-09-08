using System.Linq;
using FightArena;

namespace FightArena 
{
    public class EgonTheMoose : Heroes
    {
        Heroes heroes = new Heroes(Enumerable.Range(5, 11), Enumerable.Range(4, 4),90 );
    }
}