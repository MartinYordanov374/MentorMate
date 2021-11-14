    public interface Reptile 
    {
        bool isPoisonous {get;}

        bool isVenomous {get;}

        bool isTerritorial{get;}

        bool isSocial {get;}

        bool canSwim {get;}
        string skinColor {get;}

    }

    public interface Mammal 
    {
        int fingersCount {get;}

        int limbsCount {get;}

        string furColor {get;}

        bool isCarniovore {get;}
    }