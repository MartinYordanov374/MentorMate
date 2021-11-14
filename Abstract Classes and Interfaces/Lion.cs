using System;
class Lion : Mammal
{
    public int fingersCount {get; internal set;}
    public int limbsCount {get; internal set;}
    public string furColor {get; internal set;}
    public bool isCarniovore {get; internal set;}
    public Lion(int fingersCount, int limbsCount, bool isCarniovore, string furColor)
    {
        this.fingersCount = fingersCount;
        this.limbsCount = limbsCount;
        this.isCarniovore = isCarniovore;
        this.furColor = furColor;
    }
    public void showInfo()
    {
        Console.WriteLine("Hello, Human !");
        Console.WriteLine($"I'm a Lion");
        Console.WriteLine($"I have {this.fingersCount} fingers on each limb.");
        Console.WriteLine($"I have {this.limbsCount} limbs.");
        Console.WriteLine($"I { (this.isCarniovore == false ? "prefer vegetables" : "am fond of meat.")}");
        Console.WriteLine($"My fur is {this.furColor}.");
    }
}