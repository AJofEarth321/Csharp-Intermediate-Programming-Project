using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using LogicProblems;

namespace LogicProblems.Tests
{
    public class LogicProblemTest
    {
        LogicProblem logicProblem;

        public LogicProblemTest()
        {
            logicProblem = new LogicProblem();
        }

        [Fact]
        public void AverageWithPrecisionOf2()
        {
            int[] scores = { 1, 4, 2, 5, 6, 10 };
            double expected = (4.67);
            var actual = logicProblem.Average(scores);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AverageEmptyArrayReturns0dot00()
        {
            int[] scores = { };
            double expected = (0.00);
            var actual = logicProblem.Average(scores);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AverageThrowsExceptionForNegativeInt()
        {
            var target = new LogicProblem();
            var given = new int[] { -2 };
            var expected = "scores must be positive";
            var ex = Assert.Throws<ArgumentException>(() => target.Average(given));
            Assert.Equal(expected, ex.Message);
        }

        [Fact]
        public void LadderPathsReturnNumberOfDistinctPaths()
        {
            int rungs = (10);
            var expected = (89);
            var actual = logicProblem.DistinctLadderPaths(rungs);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LadderPath100Returns573147844013817084101()
        {
            int rungs = (100);
            decimal expected;
            if (decimal.TryParse("573147844013817084101", out expected))
            {
                var actual = logicProblem.DistinctLadderPaths(rungs);
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void LadderPathsZeroReturnsZero()
        {
            int rungs = (0);
            var expected = (0);
            var actual = logicProblem.DistinctLadderPaths(rungs);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LadderPathsThrowsExceptionForNegativeInt()
        {
            var target = new LogicProblem();
            int given = -1;
            var expected = "ladders can't have negative rungs";
            var ex = Assert.Throws<ArgumentException>(() => target.DistinctLadderPaths(given));
            Assert.Equal(expected, ex.Message);
        }

        [Fact]
        public void GroupStringsReturnsFirstLastLetterGroups()
        {
            string[] strs = { "arrange", "act", "assert", "ace" };
            var aAndEList = new List<string>() { "arrange", "ace" };
            var aAndTList = new List<string>() { "act", "assert" };
            var actual = logicProblem.GroupStrings(strs);
            Assert.Equal(aAndEList, actual[0]);
            Assert.Equal(aAndTList, actual[1]);
        }

        [Fact]
        public void GroupStringsEmptyArrayReturnsEmptyList()
        {
            string[] strs = { };
            var actual = logicProblem.GroupStrings(strs);
            Assert.Empty(actual);
        }

        [Fact]
        public void GroupStringThrowsExceptionForEmptyString()
        {
            var target = new LogicProblem();
            var given = new string[] { string.Empty };
            var expected = "strings must not be empty";
            var ex = Assert.Throws<ArgumentException>(() => target.GroupStrings(given));
            Assert.Equal(expected, ex.Message);
        }

        [Fact]
        public void LastWordLengthReturnsLength()
        {
            string text = ("It snowed on Monday");
            var expected = 6;
            var actual = logicProblem.LastWordLength(text);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LastWordLengthWhiteSpaceReturnsZero()
        {
            string text = (" ");
            var expected = (0);
            var actual = logicProblem.LastWordLength(text);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LastWordLengthEmptyStringThrowsException()
        {
            var target = new LogicProblem();
            var given = (string.Empty);
            var expected = "input must not be an empty string";
            var ex = Assert.Throws<ArgumentException>(() => target.LastWordLength(given));
            Assert.Equal(expected, ex.Message);
        }
    }
}
