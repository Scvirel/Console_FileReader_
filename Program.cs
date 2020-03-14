using System;

namespace Test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator.Pattern = @"^([a-zA-Z]:)(\\[^<>\/\\?*\" + "\"" + @"|]*)*\.txt$";

            ConsoleColorOutput.Output_Green("Hi dear User :)");

            ConsoleColorOutput.Output_Green(
                "Do you have some text file to read, or you want to create it ?" +
                "\nEnter Y - if you already have text file" +
                "\nEnter N - if want to create text file"
                );

            string _userResult = Console.ReadLine();

            switch (_userResult.ToLower())
            {
                case "y":
                    {
                        Validator.Validate();
                    }
                    break;

                case "n":
                    {
                        FileController.Create_File();
                        Validator.Validate();
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
