using System;

namespace Test_Task
{
    class ConsoleColorOutput
    {
        public static void Output_Red(string _output) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_output + "\n");
            Console.ResetColor();
        }

        public static void Output_Yellow(string _output)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_output + "\n");
            Console.ResetColor();
        }

        public static void Output_Green(string _output)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_output + "\n");
            Console.ResetColor();
        }

        public static void Output_Green(int _output)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_output + "\n");
            Console.ResetColor();
        }

        public static void Output_Usual(string _output) 
        {
            Console.WriteLine(_output + "\n");
        }
    }
}
