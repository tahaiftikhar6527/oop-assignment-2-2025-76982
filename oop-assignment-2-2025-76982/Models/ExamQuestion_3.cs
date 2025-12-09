using System;
using System.Collections.Generic;

namespace oop_assignment_2_2025_76982.Models
{
    public static class ExamQuestion_3
    {
        public static double? Average(List<int> ratings)
        {
            if (ratings == null || ratings.Count == 0) return null;
            double total = 0;
            for (int i = 0; i < ratings.Count; i++) total += ratings[i];
            return total / ratings.Count;
        }

        public static List<string> Summaries(List<(string Name, List<int> Ratings)> products)
        {
            var result = new List<string>();
            if (products == null) return result;
            foreach (var p in products)
            {
                var avg = Average(p.Ratings);
                if (avg.HasValue)
                {
                    var rounded = Math.Round(avg.Value, 1, MidpointRounding.AwayFromZero);
                    result.Add(p.Name + ": Average Rating = " + rounded.ToString("0.0"));
                }
                else
                {
                    result.Add(p.Name + ": No ratings available");
                }
            }
            return result;
        }

        public static string TopRated(List<(string Name, List<int> Ratings)> products)
        {
            if (products == null) return "No products supplied.";
            double highest = double.MinValue;
            string highestName = null;
            foreach (var p in products)
            {
                var avg = Average(p.Ratings);
                if (avg.HasValue && avg.Value > highest)
                {
                    highest = avg.Value;
                    highestName = p.Name;
                }
            }
            if (highestName == null) return "No rated products";
            var rounded = Math.Round(highest, 1, MidpointRounding.AwayFromZero);
            return "The top-rated product is " + highestName + " with an average rating of " + rounded.ToString("0.0");
        }

        public static void Run()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 }),
                ("EmptyProduct", new List<int>())
            };
            var s = Summaries(products);
            foreach (var line in s) Console.WriteLine(line);
            Console.WriteLine(TopRated(products));
        }
    }
}