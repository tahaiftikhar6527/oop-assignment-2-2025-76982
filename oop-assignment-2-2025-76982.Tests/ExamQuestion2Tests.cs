using oop_assignment_2_2025_76982.Models;
using Xunit;

namespace oop_assignment_2_2025_76982.Tests
{
    public class Question2Tests
    {
        [Theory]
        [InlineData(10, 2, "5")]
        [InlineData(9, 3, "3")]
        [InlineData(-6, 2, "-3")]
        [InlineData(10, 0, "Cannot divide by 0")]
        public void SafeDivideTests(int a, int b, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.SafeDivide(a, b));
        }

        [Theory]
        [InlineData("123", "123")]
        [InlineData("-45", "-45")]
        [InlineData("abc", "Invalid number entered.")]
        [InlineData("", "Invalid number entered.")]
        public void ConvertToIntTests(string input, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.ConvertToInt(input));
        }

        [Theory]
        [InlineData(25, "Registration successful.")]
        [InlineData(18, "Registration successful.")]
        [InlineData(17, "User must be at least 18 to register.")]
        [InlineData(0, "User must be at least 18 to register.")]
        public void RegisterTests(int age, string expected)
        {
            Assert.Equal(expected, ExamQuestion_2.Register(age));
        }
    }
}