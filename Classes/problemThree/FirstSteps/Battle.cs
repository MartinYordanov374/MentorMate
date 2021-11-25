public class Battle : Fight
{        
        private string _fighterName;

        public Hero(string fighterName)
        {
            Blood = 100;
            Attack = 10;
            Defense = 5;
            Level = 1;
            _fighterName = fighterName;
        }
        Fight_Functionality(IFighter Hero, List<Creature> enemies);
}