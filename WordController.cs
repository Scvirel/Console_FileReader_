using System;

namespace Test_Task
{
    class WordController
    {
        protected int _numberVowelsWords = 0;
        private char[] _spearator = new char[] { ' ', '!', '@', '#', '$', '%', '^','\'','\"', '&',':',';', '*', '(', ')', '_', '+', '|', '?', '>', '<', '/', '.', ',', '\\', ',', '-', '=' };
        private char[] _vowelsWords = new char[] { 'a', 'e', 'i', 'o', 'u' };


        public void GetCountVowelsWords(string _path)
        {
            string[] words = FileController.Read_File(_path).Split(_spearator, StringSplitOptions.RemoveEmptyEntries);

            ConsoleColorOutput.Output_Yellow("__Words from file : __");

            foreach (string _word in words)
            {
                int _tempCountSimbols = 0;

                ConsoleColorOutput.Output_Usual(_word);

                foreach (char _simbol in _word)
                {
                    if (Array.Find(_vowelsWords, s => s == _simbol) != default(char))
                    {
                        _tempCountSimbols++;
                    }
                }

                if (_tempCountSimbols == _word.Length)
                {
                    _numberVowelsWords++;
                }
            }
            ConsoleColorOutput.Output_Yellow("__Count Vowels words : __");
            ConsoleColorOutput.Output_Green(_numberVowelsWords);
        }


    }
}
