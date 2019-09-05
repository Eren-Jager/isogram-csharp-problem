using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class Class1
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("isogram", true)]
        [InlineData("eleven", false)]
        [InlineData("Alphabet", true)]
        [InlineData("subdermatoglyphic", true)]
        [InlineData("thumbscrew-japingly", true)]
        [InlineData("six-year-old", true)]
        [InlineData("ofcial S s", true)]

        public void Theory_Check(string value, bool expected)
        {
            Assert.Equal(expected, Program.checkiso(value));
        }

    }
}