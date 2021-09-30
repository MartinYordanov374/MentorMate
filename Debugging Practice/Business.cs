using System;

namespace Debugging_Practice
{
    class Business
    {
        // this field represents the industry sector that the business is working in
        private string industrySector;
        // this field represents all of the assets that the business posesses -> Buildings, Cars, Hardware etc. 
        private double totalAssets; 
        // this field represents all of the liabilities that a certain business has after like some debt, payables etc.
        private double totalLiabilities;
        // this field represents the working capital of the business or the money that is left after subtracting the total liabilities from the total assets
        private double workingCapital;
        // this field represents the equivalent of the assets of an acquired business e.g. -> intellectual property, brands etc.
        private double goodwill; 



        public string IndustrySector { get; set; }
        public double TotalAssets { get; set; }
        public double TotalLiabilities { get; set; }
        public double WorkingCapital { get; set; }
        public double Goodwill { get; set; }

        public Business(string businessFieldOfWork, double businessTotalAssets, double businessTotalLiabilities, double businessWorkingCapital, double businessGoodwill)
        {
            this.IndustrySector=businessFieldOfWork;
            this.TotalAssets=businessTotalAssets;
            this.TotalLiabilities=businessTotalLiabilities;
            this.WorkingCapital=businessWorkingCapital;
            this.Goodwill=businessGoodwill;
        }
        public void showBusinessData()
        {
            Console.WriteLine("showing data for your company: ");
            Console.WriteLine($"\tSector: {IndustrySector}");
            Console.WriteLine($"\tTotal Assets: {TotalAssets}");
            Console.WriteLine($"\tTotal Liabilities: {TotalLiabilities}");
            Console.WriteLine($"\tTotal Working Capital: {WorkingCapital}");
            Console.WriteLine($"\tTotal Goodwill: {Goodwill}");


            
        }
    }
}
