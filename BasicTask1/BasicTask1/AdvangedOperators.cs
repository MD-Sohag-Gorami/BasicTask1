using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class AdvangedOperators
    {
        public void OperatorsOperations()
        {
            int num1 = 100;
            int num2 = 200;
            if(num1 >100 && num2 > 100)
            {
                Console.WriteLine("num1 and num2 greater than 100 ");
            }
            else if(num1 > 100 || num2 > 100)
            {
                Console.WriteLine("One number is greater than 100");
            }
            else
            {
                Console.WriteLine("Both number smaller than 100 ");
            }
        }
    }
}
