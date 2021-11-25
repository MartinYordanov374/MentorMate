namespace FirstSteps
{
    public class Spider : Creature
    {
        public Spider()
        {
            Blood = 22;
            Attack = 15;
            Defense = 3;
            AttackType = AttackType.Poison;
        }

        public override string FighterType
        {
            get
            {
                return "Spider";
            }
        }
    }
}
