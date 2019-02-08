using System;
using Xunit;
using Web.Controllers;

namespace Web.Tests
{
    public class WebTest
    {
        [Fact]
        public void FindLineCoverage_WebController_TestFor50PcentCoverage()
        {
            int expected = 50;
            int actual = Test.FindLineCoverage(100, 50);
            Assert.Equal(expected, actual);
        }

        //Test for values that shoudl pass the test
        [Theory]
        [InlineData(230, 145, 63)]  //passing test
        [InlineData(160, 160, 100)] //passing test - 100% line coverage
        [InlineData(120, 0, 0)] // paseing test - no line coverage
        [InlineData(240, 300, -1)] //passing test - else condition (lines covered are grater than total lines)
        [InlineData(100, -50, -1)] // passing test - else condition (minus number of covered lines)

        public void FindLineCoverage_WebController_TestForPassCases(int totalLine, int coveredLine, int coverage)  
        {
            int expected = coverage;
            int actual = Test.FindLineCoverage(totalLine, coveredLine);
            Assert.Equal(expected, actual);
        }        
    }
}
