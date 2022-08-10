using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTask1
{
    public class Operators
    {

        public void OperarorsImplementation()
        {
            int num1 = 135;
            int num2 = 8;
            int addTwoNum = num1 + num2;
            Console.WriteLine("Adding two numbers :" + num1 + " + " + num2 + " = " + addTwoNum);
            int div = num1 / num2;
            Console.WriteLine("Division of  two numbers :" + num1 + " / " + num2 + " = " + div);
            int reminder = num1 % num2;
            Console.WriteLine("Modulas Operator :" + num1 + " % " + num2 + " = " + reminder);
            int mul = num1 * num2;
            Console.WriteLine("Multiplications of two number :" + num1 + " *  " + num2 +" " + mul);
            int Xor = num1 ^ num2;
            Console.WriteLine("Xor of two numbers :" + num1 + " ^ " + num2 + " " + Xor);
            int or = num1 | num2;
            Console.WriteLine("OR of two numbers :" + num1 + " |  " + num2 + " " + or);
            int And = num1 & num2;
            Console.WriteLine("AND of two numbers :" + num1 + " &  " + num2 + " " + And);



        }
        

    }
}
