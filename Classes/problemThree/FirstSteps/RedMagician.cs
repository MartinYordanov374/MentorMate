namespace FirstSteps
{
    public class RedMagician : Magician
    {
        public RedMagician()
        {
            Blood = 40;
            Attack = 31;
            Defense = 0;
            MagicEnergy = GetRandomNumber(20, 80);
        }

        public override string FighterType
        {
            get
            {
                return "Red self healing magician";
            }
        }

        public override void ReceiveHit(int forseApplied)
        {
            if (CanApplyMagicEnergy())
            {
                // self heal before taking the hit
                Blood += forseApplied / 3;
            }

            base.ReceiveHit(forseApplied);
        }
    }
}
