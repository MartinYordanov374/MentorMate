namespace FirstSteps
{
    public abstract class Creature : BaseFighter
    {
        public AttackType AttackType { get; protected set; } = AttackType.None;

        public override int ProduceHit()
        {
            double hitModifier = 1;
            if (AttackType == AttackType.Poison)
            {
                if(GetRandomNumber(1, 6) > 4)
                {
                    hitModifier = 1.5;
                }
            }

            if (AttackType == AttackType.Bite)
            {
                if (GetRandomNumber(1, 6) > 2)
                {
                    hitModifier = 1.2;
                }
            }

            return (int)(hitModifier * base.ProduceHit());
        }

        public override void DisplayObject()
        {
            base.DisplayObject();
            base.Display($"Attack type {AttackType}");
        }
    }
}
