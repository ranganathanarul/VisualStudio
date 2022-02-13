using System;

namespace DataStructre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove Duplicte in  String 
            Console.WriteLine("Remove the Duplicate Value : " + RemoveDuplicateCharsInString("Remove Duplicate Value") + "\n");

            //Reverse String
            Console.WriteLine("Reverse the String  : " + StringRevere("Remove Duplicate Value") + "\n");

            //SubString in string.
            SubString("SubstringToFind");
             
            Console.ReadLine();
        }
        static string RemoveDuplicateCharsInString(string inputStrValue)
        {
            // Store encountered letters in this string.
            string tble = string.Empty;

            // Store the result in this string.
            string reValue = string.Empty;

            // Loop over each character.
            foreach ( char chrValue in inputStrValue)
            {
                // See if character is in the table.
                if (tble.IndexOf(chrValue) == -1)
                {
                    // Append to the table and the result.
                    tble += chrValue;
                    reValue += chrValue;
                }
            }
            return reValue;
        }

        static string StringRevere(string InputStrValue)
        {
            // Store the result in this string.
            string returnString = string.Empty;
            
            for (int i = InputStrValue.Length - 1; i >= 0; i--)
                returnString += InputStrValue[i];
            
            return returnString;
        }

        static void SubString(string InputStrValue)
        {
            // Store the result in this string.
            string returnString = string.Empty;

            Console.WriteLine("SubString.");

            // Avoid full length.
            for (int length = 1; length < InputStrValue.Length; length++)
            {
                // End index is tricky.
                for (int start = 0; start <= InputStrValue.Length - length; start++)
                {
                    string substring = InputStrValue.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
            
        }
    }
}
