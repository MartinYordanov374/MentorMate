using System;

namespace FirstSteps
{
    public abstract class Magician : BaseFighter
    {
        public int MagicEnergy { get; protected set; } = 0;
        
        protected bool CanApplyMagicEnergy()
        {
            bool result = false;

            if (GetRandomNumber(1, 100) < MagicEnergy)
            {
                result = true;
            }

            // Reduce the energy for the next round
            MagicEnergy = MagicEnergy / 2;

            return result;
        }

        public override void DisplayObject()
        {
            base.DisplayObject();
            base.Display($"Magic energy {MagicEnergy}");
        }
    }
}
