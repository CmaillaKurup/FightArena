namespace FightArena
{
    public class Heroes
    {
        private int hitPoints;
        private int attackRange;
        private int defenceRange;
        //private IEnumerable<int> defenceRange = Enumerable.Range(0,0);
        //private IEnumerable<int> attackRange = Enumerable.Range(0,0);

        private string heroe;

        public string Heroe
        {
            get => heroe;
            private set => heroe = value;
        }

        public Heroes()
        {
            
        }
        public Heroes(int attackRange, int defenceRange, int hitPoints)
        {
            attackRange = AttackRange;
            defenceRange = DefenceRange;
            hitPoints = HitPoints;
        }
        public int AttackRange
        {
            get => attackRange;
            private set => attackRange = value;
        }

        public int DefenceRange
        {
            get => defenceRange;
            private set => defenceRange = value;
        }

        public int HitPoints
        {
            get => hitPoints;
            private set => hitPoints = value;
        }
    }
}