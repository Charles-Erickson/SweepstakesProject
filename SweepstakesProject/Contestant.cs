using SweepstakesProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Contestant: INeedsInfo
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public int RegistrationNumber;
        public List<Contestant> Contestants;
        public List<int> Numbers;


        public Contestant()
        {
            Contestants = new List<Contestant>();
            RegistrationNumber = 0;
            Numbers = new List<int>();
            
        }

        public void NewContestant()
        {
            string[] array = new string[3];
            EnterFirstname();
            EnterLastname();
            EnterEmail();
            GetRegistarNumber();
            Numbers.Add(RegistrationNumber);
            array[0]=FirstName;
            array[1] = LastName;
            array[2] = Email;
            Contestants.Add(array);
        }

        public int GetRegistarNumber()
        {
            RegistrationNumber = RegistrationNumber++;
            return RegistrationNumber;
        }

        public string EnterFirstname()
        {
            Console.WriteLine("Please enter your First name.");
            FirstName = Console.ReadLine();
            return FirstName;
        }

        public string EnterLastname()
        {
            Console.WriteLine("Please enter your Last name.");
            LastName = Console.ReadLine();
            return LastName;
        }

        public string EnterEmail()
        {
            Console.WriteLine("Please enter your email.");
            Email = Console.ReadLine();
            return Email;
        }
    }
}
