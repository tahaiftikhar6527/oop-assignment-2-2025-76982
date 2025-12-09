using System;
using System.Globalization;

namespace oop_assignment_2_2025_76982.Models
{
    public static class ExamQuestion_4
    {
        public static string FormatFiveDigits(int value)
        {
            return value.ToString("D5", CultureInfo.InvariantCulture);
        }

        public static string FormatPrice(double price)
        {
            var number = price.ToString("N2", CultureInfo.InvariantCulture);
            return "€" + number;
        }

        public static void Run()
        {
            Console.WriteLine(FormatFiveDigits(42));
            Console.WriteLine(FormatPrice(1234.5));
        }
    }
}