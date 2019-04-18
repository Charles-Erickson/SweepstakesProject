using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Sweepstakes;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> ContestantList = new Dictionary<int, Contestant>();
         
        public string name;
      
        public void RegistarContestant(Contestant contestant)
        {
            for(int i = 0; i < contestant.Contestants.Count; i++)
            {
                int id = contestant.Numbers[i];
                ContestantList.Add(id, contestant.Contestants[i]);
            }
        }

        public string PickWinner()
        {
            Random rand = new Random();
            Contestant contestant = new Contestant();
            int num=rand.Next(0, ContestantList.Count);
            Contestant value = ContestantList.Values.ElementAt(num);
            PrintContestantInfo(contestant, num);
            name = value;
            return name;
        }

       public void PrintContestantInfo(Contestant contestant,int num)
        {
            Console.WriteLine("The name of the Winner is " + contestant.Contestants[num].array[0] + contestant.Contestants[num].array[1]);
            Console.WriteLine("The Email of the winner is " + contestant.Contestants[num].array[2]);
            Console.ReadKey();
        }
    }
}
