namespace FirstSteps
{
    public class BlueMagician : Magician
    {
        public BlueMagician()
        {
            Blood = 30;
            Attack = 28;
            Defense = 5;
            MagicEnergy = GetRandomNumber(30, 100);
        }

        public override string FighterType
        {
            get
            {
                return "Blue aggressive magician";
            }
        }

        public override int ProduceHit()
        {
            int attack = base.ProduceHit();

            if (CanApplyMagicEnergy())
            {
                // double the attack for bigger impact
                attack *= 2;
            }
            return attack;
        }
    }
}
