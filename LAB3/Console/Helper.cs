using static System.Console;
using System.Globalization;

namespace LAB3.Console
{
    public class Helper
    {
        public static DateTime GetDateFromConsole(
            string message = "Please enter date in format dd-MM-yyyy: ")
        {
            DateTime dt;
            string input;
            do
            {
                Clear();
                WriteLine(message);
                input = ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out dt));

            return dt;
        }
        public static string GetStringFromConsole(string message, int neededSymbols = 0)
        {
            string input;
            if (neededSymbols != 0)
            {
                do
                {
                    Clear();
                    WriteLine(message);
                    input = ReadLine();
                }
                while (String.IsNullOrEmpty(input) && input.Length == neededSymbols);
            }
            else
            {
                do
                {
                    Clear();
                    WriteLine(message);
                    input = ReadLine();
                }
                while (String.IsNullOrEmpty(input));
            }
            return input;
        }
        public static int GetIntFromConsole(string message, int neededSymbols = 0)
        {
            string input;
            int result = 0;
            bool success = false;
            
            if (neededSymbols != 0)
            {
                do
                {
                    Clear();
                    WriteLine(message);
                    input = ReadLine();
                    if (!String.IsNullOrEmpty(input))
                    {
                        if (int.TryParse(input, out int res))
                        {
                            result = res;
                            success = true;
                        }
                    } 
                }
                while (input.Length == neededSymbols && !success);
            }
            else
            {
                do
                {
                    Clear();
                    WriteLine(message);
                    input = ReadLine();
                    if (!String.IsNullOrEmpty(input))
                    {
                        if (int.TryParse(input, out int res))
                        {
                            result = res;
                            success = true;
                        }
                    }
                }
                while (!success);
            }
            return result;
        }
    }
}
