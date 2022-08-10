using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class ConversionMethod
    {
        public void ConvertMethod()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            string myString = "123";
            char myChar = 'a';

            
            Console.WriteLine(Convert.ToInt32(myString));
            Console.WriteLine(Convert.ToDouble(myString));
            Console.WriteLine(Convert.ToSingle(myString));
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));    
            Console.WriteLine(Convert.ToInt32(myDouble));  
            Console.WriteLine(Convert.ToString(myBool));
            Console.WriteLine(Convert.ToInt32(myChar));
            
        }
    }
}
