﻿
using System ;
namespace BasicTask1
{

    class Program
    {
        static void Main(string[] args )
        {
            //Task1 
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.HelloWorldPrint();
            
            //Task2 "All primitive type" 

            PrimitiveType primitiveType = new PrimitiveType();
            primitiveType.PrimitiveTypePrint();

            // task3 OverFlow Checking 
            OverFlowCheck check = new OverFlowCheck();
            int value = check.CheckedMethod();
            Console.WriteLine(value);
            int value2 = check.UncheckedMethod();
            Console.WriteLine(value2);

            // Taks4 Coverting one type to another
            ConversionMethod conversionMethod = new ConversionMethod();
            conversionMethod.ConvertMethod();

            // Task5 Implementation of different operators 
            Operators operators = new Operators();
            operators.OperarorsImplementation();
            







        }
    }
}