using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Test_Task
{
    class Validator
    {
        public static string Pattern{get;set;}
        private static string FilePath { get; set; }

        public static void Validate() 
        {
            ConsoleColorOutput.Output_Yellow("Please enter full path to your text file.");
            
            FilePath = Console.ReadLine();

            Check();

        }
        private static void Check() {
            WordController _wordController = new WordController();

            Match m = Regex.Match(FilePath, Pattern, RegexOptions.Compiled);

            if (m.Success && File.Exists(FilePath))
            {
                ConsoleColorOutput.Output_Green("Path validation succes :)");

                _wordController.GetCountVowelsWords(FilePath);

                return;
            }
            else
            {
                ConsoleColorOutput.Output_Red("Validation Error :(\nCheck your path and try again");
                Validate();
            }
        }
    }
}
