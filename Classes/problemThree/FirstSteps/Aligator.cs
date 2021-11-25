namespace FirstSteps
{
    public class Aligator : Creature
    {
        public Aligator()
        {
            Blood = 40;
            Attack = 31;
            Defense = 0;
            AttackType = AttackType.None;
        }

        public override string FighterType
        {
            get
            {
                return "Aligator";
            }
        }
    }
}
