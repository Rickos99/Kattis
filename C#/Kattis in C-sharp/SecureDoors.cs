using System;
using System.Collections.Generic;

namespace Kattis_in_C_sharp
{
    static class SecureDoors
    {
        //public static void Main() => Solution();
        
        public static void Solution()
        {
           int inputs = int.Parse(Console.ReadLine());
           Dictionary<string, bool> employeeEntered = new Dictionary<string, bool>();

           while (inputs-- > 0)
           {
               string[] input = Console.ReadLine().Split(' ');
               if (input[0] == "entry")
               {
                   if (!employeeEntered.ContainsKey(input[1]) || !employeeEntered[input[1]])
                   {
                       Console.WriteLine($"{input[1]} entered");
                       employeeEntered[input[1]] = true;
                   }
                   else
                   {
                       Console.WriteLine($"{input[1]} entered (ANOMALY)");
                   }
               }
               else // input[0] == "exit"
               {
                   if (employeeEntered.ContainsKey(input[1]) && employeeEntered[input[1]])
                   {
                       Console.WriteLine($"{input[1]} exited");
                       employeeEntered[input[1]] = false;
                   }
                   else
                   {
                       Console.WriteLine($"{input[1]} exited (ANOMALY)");
                   }
               }

           }
        }
    }
}
