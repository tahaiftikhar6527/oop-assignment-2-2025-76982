using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_76982.Models
{
    public static class ExamQuestion_1
    {
        private static readonly Regex IrishMobileRegex = new Regex("^(083|085|089)\\d{7}$");

        public static bool IsValidMobile(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) return false;
            return IrishMobileRegex.IsMatch(number.Trim());
        }

        public static int DiscountForLevel(string level)
        {
            if (string.IsNullOrWhiteSpace(level)) return 0;
            var map = new Dictionary<string, int>(StringComparer.Ordinal)
            {
                ["Bronze"] = 1,
                ["Silver"] = 5,
                ["Gold"] = 10,
                ["Platinum"] = 15,
                ["Diamond"] = 20,
                ["Elite"] = 25,
                ["BOSS"] = 30
            };
            return map.TryGetValue(level.Trim(), out var discount) ? discount : 0;
        }

        public static void Run()
        {
	
            Console.WriteLine(IsValidMobile("0831234567"));
            Console.WriteLine(DiscountForLevel("Gold"));
        }
    }
}