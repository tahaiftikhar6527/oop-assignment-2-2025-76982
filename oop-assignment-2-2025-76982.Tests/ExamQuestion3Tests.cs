using System.Collections.Generic;
using oop_assignment_2_2025_76982.Models;
using Xunit;

namespace oop_assignment_2_2025_76982.Tests
{
    public class Question3Tests
    {
        [Fact]
        public void AverageTests()
        {
            var ratings = new List<int> { 5, 4, 4, 5, 3 };
            var avg = ExamQuestion_3.Average(ratings);
            Assert.NotNull(avg);
            Assert.Equal(4.2, avg.Value, 1);
            Assert.Null(ExamQuestion_3.Average(new List<int>()));
            Assert.Null(ExamQuestion_3.Average(null));
        }

        [Fact]
        public void SummariesTests()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 }),
                ("EmptyProduct", new List<int>())
            };
            var result = ExamQuestion_3.Summaries(products);
            Assert.Equal(5, result.Count);
            Assert.Contains("Laptop: Average Rating = 4.2", result);
            Assert.Contains("Headphones: Average Rating = 4.0", result);
            Assert.Contains("Keyboard: Average Rating = 4.8", result);
            Assert.Contains("Mouse: Average Rating = 3.3", result);
            Assert.Contains("EmptyProduct: No ratings available", result);
        }

        [Fact]
        public void TopRatedTests()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };
            var result = ExamQuestion_3.TopRated(products);
            Assert.Equal("The top-rated product is Keyboard with an average rating of 4.8", result);
            var none = new List<(string Name, List<int> Ratings)>
            {
                ("A", new List<int>()),
                ("B", null)
            };
            Assert.Equal("No rated products", ExamQuestion_3.TopRated(none));
        }
    }
}