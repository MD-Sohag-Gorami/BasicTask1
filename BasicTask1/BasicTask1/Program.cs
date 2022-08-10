
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

            // Task6 IF ELSE statetment 
            IfElseStatetment ifElseStatetment = new IfElseStatetment();
            ifElseStatetment.IfElse();

            //Taks7 && and || operators 
            AdvangedOperators advangedOperators = new AdvangedOperators();
            advangedOperators.OperatorsOperations();
            
            //Task8 Ternary Operators
            TernaryOperators ternaryOperators = new TernaryOperators();
            ternaryOperators.TernaryOperatosImplementations();

            







        }
    }
}