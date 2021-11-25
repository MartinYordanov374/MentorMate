public class Fight
{
    public void Fight_Functionality(IFighter Hero, List<Creature> enemies)
    {
        foreach(var enemyFighter in enemies)
        {
            do
            {
                enemyFighter.ReceiveHit(ProduceHit());
                if (enemyFighter.IsAlive)
                {
                    int enemyStrikeForse = enemyFighter.ProduceHit() - Defense;
                    if (enemyStrikeForse > 0)
                    {
                        ReduceBlood(enemyStrikeForse);
                    }
                }
            }
            while (Hero.IsAlive && enemyFighter.IsAlive);
            if (IsAlive)
            {
                Level++;
                AddBooster();
            }
        }
    }   
}

