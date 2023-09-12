using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(message))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInteger(this string message)
        {
            return message.RequestInteger(false);
        }

        public static int RequestInteger(this string message, int minValue, int maxValue)
        {
            return message.RequestInteger(true, minValue, maxValue);
        }

        private static int RequestInteger(this string message, bool useRangeValidation, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInteger = false;
            bool isInRange = true;

            while (isValidInteger == false && isInRange == false)
            {
                Console.Write(message);
                isValidInteger = int.TryParse(message, out output);
                if (useRangeValidation == true) isInRange = output.IsInRange(minValue, maxValue);
            }

            return output;
        }

        private static bool IsInRange(this int number, int minValue, int maxValue)
        {
            return number >= minValue && number <= maxValue;
        }
    }
}
