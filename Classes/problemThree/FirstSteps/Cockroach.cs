namespace FirstSteps
{
    public class Cockroach : Creature
    {
        public Cockroach()
        {
            Blood = 17;
            Attack = 12;
            Defense = 0;
        }

        public override string FighterType
        {
            get
            {
                return "Cockroach";
            }
        }
    }
}
