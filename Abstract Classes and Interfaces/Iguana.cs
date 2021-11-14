using System;
class Iguana : Animal, Reptile
{
    public bool isPoisonous {get; internal set;}
    public bool isVenomous {get; internal set;}
    public bool isTerritorial {get; internal set;}
    public bool isSocial {get; internal set;}
    public bool canSwim {get; internal set;}
    public string skinColor {get; internal set;}

    public Iguana (bool isPoisonous, bool isVenomous, bool isTerritorial, bool isSocial, bool canSwim, string skinColor)
    {
        this.isPoisonous = isPoisonous;
        this.isVenomous = isVenomous;
        this.isTerritorial = isTerritorial;
        this.isSocial = isSocial;
        this.canSwim = canSwim;
        this.skinColor = skinColor;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Prrrr");
    }
    public void showInfo()
    {
        Console.WriteLine("Hello, Human !");
        Console.WriteLine($"I'm an Iguana");
        Console.WriteLine($"I { (this.isPoisonous == false ? "am not" : "am")} poisonous.");
        Console.WriteLine($"I { (this.isVenomous == false ? "am not" : "am")} venomous.");
        Console.WriteLine($"I { (this.isTerritorial == false ? "am not" : "am")} territorial.");
        Console.WriteLine($"I { (this.isSocial == false ? "am not" : "am")} a social animal.");
        Console.WriteLine($"I { (this.canSwim == false ? "can't" : "can")} swim.");
        Console.WriteLine($"I am colored in {this.skinColor}.");
    }
}