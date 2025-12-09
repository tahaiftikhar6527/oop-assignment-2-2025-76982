using System;

namespace oop_assignment_2_2025_76982.Models
{
    public static class ExamQuestion_2
    {
        public static string SafeDivide(int x, int y)
        {
            if (y == 0) return "Cannot divide by 0";
            return (x / y).ToString();
        }

        public static string ConvertToInt(string input)
        {
            if (int.TryParse(input, out var value)) return value.ToString();
            return "Invalid number entered.";
        }

        public static string Register(int age)
        {
            if (age < 18) return "User must be at least 18 to register.";
            return "Registration successful.";
        }

        public static void Run()
        {
            Console.WriteLine(SafeDivide(10, 2));
            Console.WriteLine(SafeDivide(10, 0));
            Console.WriteLine(ConvertToInt("123"));
            Console.WriteLine(ConvertToInt("abc"));
            Console.WriteLine(Register(25));
            Console.WriteLine(Register(17));
        }
    }
}