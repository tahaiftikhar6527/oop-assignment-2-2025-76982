using oop_assignment_2_2025_76982.Models;
using Xunit;

namespace oop_assignment_2_2025_76982.Tests
{
    public class Question4Tests
    {
        [Fact]
        public void FormatFiveDigitsTests()
        {
            Assert.Equal("00042", ExamQuestion_4.FormatFiveDigits(42));
            Assert.Equal("12345", ExamQuestion_4.FormatFiveDigits(12345));
            Assert.Equal("00000", ExamQuestion_4.FormatFiveDigits(0));
        }

        [Fact]
        public void FormatPriceTests()
        {
            Assert.Equal("€1,234.50", ExamQuestion_4.FormatPrice(1234.5));
            Assert.Equal("€0.00", ExamQuestion_4.FormatPrice(0));
            Assert.Equal("€9,999.99", ExamQuestion_4.FormatPrice(9999.99));
        }
    }
}