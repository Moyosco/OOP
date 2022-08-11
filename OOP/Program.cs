namespace OOP
{  
    public class CarPurchase : ICarPurchaseRules
    {
        public bool IsEngineGood  { get; set; }
        public bool IsAccidentFree { get; set; }
             
        
        
        public string Price(string brand, bool goodEngine)
        {

            return "The Price is 1 million naira";
        }
        public string Price(string brand, bool goodEngine, bool accidentFree)
        {

            return "The Price is 1.2 Million Naira";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cars available are:");
            Console.WriteLine("Honda = H,  Toyota = T Lexus = L, Mercedes = M,Skoda = S"); 
            Console.WriteLine("What brand of car do you want to buy?");
            string carBrand = Console.ReadLine(); // carbrand is storing the input of the user//
            Console.WriteLine("Which features do you prefer?");
            Console.WriteLine("Write G for Good engine and Write A for Accident free");
            string carFeatures = Console.ReadLine(); // carFeatures is storing the input of the user

            if (carFeatures.ToUpper() == "G")
            {
                var customerChoice = new CarPurchase();
                string price = customerChoice.Price(carBrand, true);
                Console.WriteLine(price);
            }else if (carFeatures == "A")
            {
                var customerChoice = new CarPurchase();
                string price = customerChoice.Price(carBrand, false, true);
                Console.WriteLine(price);
            }


            
        }
    }
}