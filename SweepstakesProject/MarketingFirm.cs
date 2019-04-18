using System;
using System.Collections.Generic;
using System.Text;
using Sweepstakes;

namespace SweepstakesProject
{
    class MarketingFirm 
    {
        public SweepstakeStackManager sweepstakeStackManager = new SweepstakeStackManager();
        public SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();


        public void ChooseStackOrQueue()
        {
            Console.WriteLine("Would you Like to use Queue or Stack data structure?");
            string data = Console.ReadLine();
            switch (data)
            {
                case "Stack":
                    data = "Stack";
                    
                case "Queue":
                    data = "Queue";
            }
            if (data == "Stack")
            {
                sweepstakeStackManager.GetSweepstakes();
                sweepstakeStackManager.InsertSweepstakes(Sweepstakes sweepstakes);
            }
            else if (data == "Queue")
            {
                sweepstakesQueueManager.GetSweepstakes();
                sweepstakesQueueManager.InsertSweepstakes(Sweepstakes sweepstakes);
            }
        }
        
    }
}
