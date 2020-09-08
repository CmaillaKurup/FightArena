using System.Collections.Generic;
using System.Linq;

namespace FightArena
{
    public class Heroes
    {
        //private int attackRange;
        //private int defence;
        private int hitPoints;
        
        private IEnumerable<int> defenceRange = Enumerable.Range(0,0);
        private IEnumerable<int> attackRange = Enumerable.Range(0,0);


        public Heroes(IEnumerable<int> attackRange, IEnumerable<int> defenceRange, int hitPoints)
        {
            attackRange = AttackRange;
            defenceRange = DefenceRange;
            hitPoints = HitPoints;
        }
        public IEnumerable<int> AttackRange
        {
            get => attackRange;
            set => attackRange = value;
        }

        public IEnumerable<int> DefenceRange
        {
            get => defenceRange;
            set => defenceRange = value;
        }

        public int HitPoints
        {
            get => hitPoints;
            set => hitPoints = value;
        }
    }
}