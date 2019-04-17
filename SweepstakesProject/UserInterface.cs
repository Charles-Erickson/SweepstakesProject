using System;
using System.Collections.Generic;
using System.Text;

namespace SweepstakesProject
{
    abstract class UserInterface
    {
        public interface INeedsInfo
        {
            string EnterFirstname();
            string EnterLastname();
            string EnterEmail();
        }

    }
}
