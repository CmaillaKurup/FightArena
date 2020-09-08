namespace FightArena
{
    public class Heroes
    {
        private int attackRange;
        private int defence;
        private int hitPoints;

        public Heroes(int attackRange, int defence, int hitPoints)
        {
            attackRange = AttackRange;
            defence = Defence;
            hitPoints = HitPoints;
        }
        public int AttackRange
        {
            get => attackRange;
            set => attackRange = value;
        }

        public int Defence
        {
            get => defence;
            set => defence = value;
        }

        public int HitPoints
        {
            get => hitPoints;
            set => hitPoints = value;
        }
    }
}