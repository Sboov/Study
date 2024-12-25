namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in Calculator!!");
            Console.WriteLine("What are A and B?");
            
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Your options are:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division");
            Console.WriteLine("Type your choice using '1' , '2' , '3' or '4'");
            int userInput = int.Parse(Console.ReadLine());
            
            switch (userInput)
            {
                case 1:
                    double resultA = a + b;
                    Console.WriteLine($"Result of addition {a} and {b} is {resultA}");
                    break;
                case 2:
                    double resultS = a - b;
                    Console.WriteLine($"Result of Subtraction {a} and {b} is {resultS}");
                    break;
                case 3:
                    double resultM = a * b;
                    Console.WriteLine($"Result of Multiplication {a} and {b} is {resultM}");
                    break;
                case 4:
                    double resultD = a / b;
                    Console.WriteLine($"Result of Division {a} and {b} is {resultD}");
                    break;
                default:
                    Console.WriteLine("Somewhat you fuckedup.");
                    return;

                   


                    
                    

            }
            
            Console.ReadKey();
        }
        
        
    }
}
        