﻿using SweepstakesProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    public class Contestant: INeedsInfo
    {
        string FirstName;
        string LastName;
        string Email;
        int RegistrationNumber;   

        public Contestant()
        {
            RegistrationNumber = RegistrationNumber++;
            EnterFirstname();
            EnterLastname();
            EnterEmail();
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
