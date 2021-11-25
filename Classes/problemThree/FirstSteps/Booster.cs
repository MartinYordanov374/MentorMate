using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    public class Booster : BaseDisplayableUnit
    {
        public Booster(BoosterTypes type, int level)
        {
            Type = type;
            Level = level;
        }

        public BoosterTypes Type { get; private set; }
        public int Level { get; private set; }

        public override void DisplayObject()
        {
            string description = string.Empty;

            switch (Type)
            {
                case BoosterTypes.Healing:
                    description = $"Increases your blood with {Level}";
                    break;
                case BoosterTypes.Armor:
                    description = $"Increase your armor with {Level}";
                    break;
                case BoosterTypes.Energy:
                    description = $"Boost your attack energy with {Level}%";
                    break;
            }

            Display(description, ConsoleColor.Green);
        }
    }
}
