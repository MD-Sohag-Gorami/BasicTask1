using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class OverFlowCheck
    {
        
       
        int maxIntValue = 2147483647;
        public  int CheckedMethod()
        {
            Console.WriteLine("OverFlow Checking");
            int checkValue = 0;
            try
            {
                checkValue = checked(maxIntValue + 16);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Over Flow occurs !! ");
            }
           
            return checkValue;
        }

        public  int UncheckedMethod()
        {
            Console.WriteLine("OverFlow Checking");
            int checkValue = 0;
            try
            {

                checkValue = maxIntValue + 10;
            }
            catch (System.OverflowException e)
            {

                Console.WriteLine("Over Flow occurs !! ");
            }
            Console.WriteLine();
           
            return checkValue;
        }

       
     
    }
}
