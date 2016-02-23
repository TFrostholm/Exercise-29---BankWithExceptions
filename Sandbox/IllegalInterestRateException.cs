using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This exception is to be thrown in case the bank account
    // is defined with an illegal interest rate
    class IllegalInterestRateException : Exception
    {
        public IllegalInterestRateException(string message)
            : base(message)
        {
            Console.WriteLine("Illegal interest rate. Must be between 0.0 and 20.0");
            Console.ReadKey();
        }
    }
}
