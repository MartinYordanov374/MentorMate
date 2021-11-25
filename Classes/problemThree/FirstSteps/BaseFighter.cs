using System;

namespace FirstSteps
{
    public abstract class BaseFighter : BaseDisplayableUnit, IFighter
    {
        public bool IsAlive { get; protected set; } = true;
        public int Blood { get; protected set; }
        public int Attack { get; protected set; }
        public int Defense { get; protected set; }
        public abstract string FighterType { get; }

        private Random _random = new Random();

        protected int GetRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public virtual void ReceiveHit(int forseApplied)
        {
            ReduceBlood(forseApplied - Defense);
        }

        public virtual int ProduceHit()
        {
            return Attack;
        }

        public override void DisplayObject()
        {
            Display($"Fighter: {FighterType}", ConsoleColor.Yellow);
            Display($"Blood: {Blood}");
            Display($"Attack: {Attack}");
            Display($"Defense: {Defense}");

        }

        protected void ReduceBlood(int amountOfBloodToReduce)
        {
            Display($"{FighterType} recieves {amountOfBloodToReduce} damage", ConsoleColor.Red);
            if ((Blood - amountOfBloodToReduce) <= 0)
            {
                Blood = 0;
                IsAlive = false;
            }
            else
            {
                Blood -= amountOfBloodToReduce;
            }
        }
    }
}
