﻿using System.Collections.Generic;
using Xunit;

namespace XUnitExample.Tests
{
    public class FiboTests
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Fibo();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var calc = new Fibo();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Fibo();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Fibo();
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}
