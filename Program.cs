using System;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# programming");
            Console.WriteLine("Welcome to IBM Training");
            
            string name = "sahithi";
            string address = "Godavarikhani";
            Console.WriteLine("My Name is: "+ name);
            Console.WriteLine("My Name is {0} and I am from {1}",name,address);

            int c = 3 + 3;
            Console.WriteLine("c=" + c);
          
            // greatest of three numbers
            int n1, n2, n3;
            Console.Write("Enter 1st number: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3)
            {
                Console.Write("n1 is greatest");
            }
            else if(n2 > n1 && n2 > n3)
            {
                Console.Write("n2 is greatest");
            }
            else if (n3 > n1 && n3 > n1)
            {
                Console.Write("n3 is greatest");
            }
            Console.ReadLine();


            // Swap two numbers without using third variale
            int a = 10, b = 30;
            Console.WriteLine("Value of a is: "+ a);
            Console.WriteLine("Value of b is: "+ b);
            a = a +b;
            b = a-b;
            a = a - b;
            Console.WriteLine("After Swapping");
            Console.WriteLine("New value of a: "+ a);
            Console.WriteLine("New value of b: "+ b);
            Console.ReadLine();

            // program to display Employee details

            Console.WriteLine("Employee Details");
            string emp_Name="Sahithi";
            string emp_id="003C3T";
            Console.WriteLine("Employee Name is: " + emp_Name);
            Console.WriteLine("Employee Id is : " + emp_id);
            Console.ReadLine();

            // program to create simple calculator using switch case
            int num1;
            int num2;
            string operand;
            float answer;

            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();

            //calculate sum of n Natural numbers

            int i, num = 5, sum = 0;
            for (i = 1; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Sum of first" + num +
            " natural numbers = " + sum);
            Console.ReadLine();
        }
    }
}
