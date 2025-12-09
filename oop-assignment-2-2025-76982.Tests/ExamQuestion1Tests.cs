using oop_assignment_2_2025_76982.Models;
using Xunit;

namespace oop_assignment_2_2025_76982.Tests
{
    public class Question1Tests
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0899988776", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void MobileValidation(string number, bool expected)
        {
            Assert.Equal(expected, ExamQuestion_1.IsValidMobile(number));
        }

        [Theory]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Elite", 25)]
        [InlineData("Unknown", 0)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void MembershipDiscount(string level, int expected)
        {
            Assert.Equal(expected, ExamQuestion_1.DiscountForLevel(level));
        }
    }
}