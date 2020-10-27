using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"
            };

             Console.WriteLine(" which day u want b?");
             Console.Write("(Monday = 1 , etc. ) >");
             int iDay = int.Parse(Console.ReadLine()) - 1;

             string chosenDay = daysOfWeek[iDay];
             Console.WriteLine($"Tha day is {chosenDay}");
        }
    }
}

// stuff i already know 