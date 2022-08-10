using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class PrimitiveType
    {
        public void PrimitiveTypePrint()
        {
            Console.WriteLine("Primitive Type \n");
            int intVal = 100;
            double doublVal = 8.358674532;
            char charVal = 'S';
            string stringVal = "Sohag";
            float floatVal = 3.7330645f;
            long longVal = 123456;
            uint uintVal = 97;
            ulong ulongVal = 18888;
            Console.WriteLine("Integar : " + intVal);
            Console.WriteLine("Double : " + doublVal);
            Console.WriteLine("Char : " + charVal);
            Console.WriteLine("String : " + stringVal);
            Console.WriteLine("float : " + floatVal);
            Console.WriteLine("long : " + longVal);
            Console.WriteLine("Unsigned  : " + uintVal);
            Console.WriteLine("Unsigned long : " + ulongVal);
            Console.WriteLine();


        }
    }
}
