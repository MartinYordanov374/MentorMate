using System;

namespace FirstSteps
{
    public abstract class BaseDisplayableUnit
    {
        public abstract void DisplayObject();

        protected void Display(string textToDisplay, ConsoleColor color = ConsoleColor.White)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(textToDisplay);
            Console.ForegroundColor = originalForegroundColor;
        }
    }
}
