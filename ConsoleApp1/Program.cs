using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer();
            customer1.GetDetails();
            customer1.Saving();
            double interestd;
           interestd= customer1.Interest();
          double reward = 0;
           reward=customer1.GetForDuration6(interestd);
            Console.WriteLine("your reward is");
            Console.WriteLine(reward);
          reward = customer1.GetForDuration12(interestd);
            Console.WriteLine("your reward is");
            Console.WriteLine(reward);
           reward = customer1.GetForDuration24(interestd);
            Console.WriteLine("your reward is");
            Console.WriteLine(reward);
            reward = customer1.GetForDuration60(interestd);
            Console.WriteLine("your reward is");
            Console.WriteLine(reward);

        }
    }


    class Customer
    {
        public double savings;
        public string type;
        public double interest = 0;
        public  int duration = 0;
        public void GetDetails()
        {
            Console.WriteLine("Welcome to Wema Bank");
            Console.WriteLine("Please Enter ypur Account name");
            string accountName = Console.ReadLine();
            Console.WriteLine("Please Enter ypur Account number");
            double accountNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter ypur Account type either savings,current,corporate or domicilliary");
            type = Console.ReadLine();
           
        }
    
        public  void Saving()
        {
          Console.WriteLine("please enter amount you which to save");
            savings =double.Parse( Console.ReadLine());

        }
   
        public double Interest()
                
        {
             double  interesti = 0;
            switch (type)
            { case "savings" : interesti = savings * 5;
                    return interesti;
                case "current":
                    interesti = savings * 5/100;
                    return interesti;
                case "corporate":
                    interesti = savings * 10/100;
                    return interesti;
                case "domicilliary":
                    interesti = savings * 15/100;
                    return interesti;
            }
            return interesti;
        }

        public double GetForDuration6( double interest6) {
          double interest=interest6 * 6; 
             
            return interest;
        }
        public double GetForDuration12(double interest12  )
        {
             double interest=interest12 * 12; 
             
            return interest;
           
        }

        public double GetForDuration24(double interest24)
        {
            double interest=interest24 * 24; 
             
            return interest;
        }
        public double GetForDuration60(double interest60 )
        {
           
             double interest=interest60 * 60; 
             
            return interest;
        }

        //public double GetForDuration()
        //{
        //    //  Console.WriteLine("please enter duration");
        //  //  duration =int.Parse(Console.ReadLine());
        //  //  if (duration==6) { interest = interest * 12; return interest; }
        //  // else  if (duration == 12) { interest = interest * 12; return interest; }
        //  //else   if (duration == 24) { interest = interest * 12; return interest; }
        //  //else   if (duration == 60) { interest = interest * 12; return interest; }
        //  //  return interest;
        //}

    }
}
  
     



