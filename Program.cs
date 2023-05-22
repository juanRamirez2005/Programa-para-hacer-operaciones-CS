namespace Test_para_identificar_tecla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----What would you like to do?----\n1- Addition\n2 -Substraction\n3 -Multiplication\n4- Division"
               
);
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            string operationSelected = null;
            switch (keyPressed.Key) {
                case ConsoleKey.D1:
                    operationSelected = "+";
                    break;
                case ConsoleKey.D2:
                    operationSelected = "-";
                    break;
                case ConsoleKey.D3:
                    operationSelected = "*";   
                    break;
                case ConsoleKey.D4:
                    operationSelected = "/";
                    break;
                default:
                    Console.WriteLine("That's not a valid option");
                    break;

            }
            if(operationSelected == null)
            {
               Console.WriteLine("Try again :(");
            }
            else
            {
                Console.WriteLine("You have selected The " + operationSelected + " operator");

                Console.WriteLine("----Introduce the First number----");
                string firstNumber = Console.ReadLine();
                Console.WriteLine("----Introduce the second number----");
                string secondNumber = Console.ReadLine();
                Solution(firstNumber, secondNumber, operationSelected);
                static void Solution(string firstNumber, string secondNumber, string operation)
                {
                    int result;
                    int num1;
                    int num2; 
                    try
                    {
                        num1 = Int32.Parse(firstNumber);
                        num2 = Int32.Parse(secondNumber);

                        if (operation == "+")
                        {
                            result = num1 + num2;
                            Console.WriteLine(result);
                        }
                        else if(operation == "-")
                        {
                            result = num1 - num2;
                            Console.WriteLine(result);
                        }
                        else if(operation == "*")
                        {
                            result = num1 * num2;
                            Console.WriteLine(result);
                        }
                        else if(operation == "/")
                        {
                            decimal quocient = (decimal)num1 / (decimal)num2;
                            Console.WriteLine(quocient);
                        }                        

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message,"Something went wrong, try again :(");
                    }
                }
            }
        }
    }
}