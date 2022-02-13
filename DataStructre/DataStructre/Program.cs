using System;

namespace DataStructre
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Remove the Duplicate Value : " + RemoveDuplicateCharsInString("Remove Duplicate Value"));
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
    }
}
