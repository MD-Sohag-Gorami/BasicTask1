using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class IfElseStatetment
    {
        public void IfElse()
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int value = 40;
            if(value < 50)
            {
                if (value > 42)
                {

                    Console.WriteLine("Wow !");
                }
                else { Console.WriteLine("Simple :"); }
                    
                
         
            }
        }
    }
}
