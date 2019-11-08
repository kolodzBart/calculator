using System;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;
            string message;
            bool opstype;

            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("-------------------\r");

            Console.WriteLine("Enter first number\r");
            firstnum = double.Parse(Console.ReadLine());

            // Console.WriteLine("Select an operator: (+,-,*,/)\r");
            // ops = Console.ReadLine();

            do
            {
                Console.WriteLine("Select an operator: (+,-,*,/)\r");
                ops = Console.ReadLine();

                opstype = Equals(ops, "+") || Equals(ops, "-") || Equals(ops, "/") || Equals(ops, "*");
            }
            while (opstype == false);

            Console.WriteLine("Enter second number\r");
            secondnum = double.Parse(Console.ReadLine()); 

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write(answer);
            }
            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write(answer);
            }
            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write(answer);
            }
            if (ops == "/")
            {
                if (secondnum == 0)
                {
                    message = "You cannot divide by 0";
                    Console.Write(message);
                }
                else
                {
                    answer = firstnum / secondnum;
                    Console.Write(answer);
                }
            }
            Console.ReadKey();
        }
    
    }
}
