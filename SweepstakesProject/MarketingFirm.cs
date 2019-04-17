using System;
using System.Collections.Generic;
using System.Text;
using Sweepstakes;

namespace SweepstakesProject
{
    class MarketingFirm 
    {
        public SweepstakeStackManager sweepstakeStackManager = new SweepstakeStackManager();


        public void ChooseStackOrQueue()
        {
            Console.WriteLine("Would you Like to use Queue or Stack data structure?");
            string data = Console.ReadLine();
            switch (data)
            {
                case "Stack":
                    data = "Stack";
                    return data;

                case "Queue":
                    data = "Queue";
                    return data;


                 
        


            }
        }
        
    }
}
