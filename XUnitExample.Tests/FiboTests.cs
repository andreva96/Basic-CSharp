using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace XUnitExample.Tests
{
    public class FiboFixture : IDisposable
    {
        public Fibo calc => new Fibo();

        public void Dispose()
        {
            //clean
        }
    }

    public class FiboTests : IClassFixture<FiboFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryStream memoryStream;
        private readonly FiboFixture _fiboFixture;

        public FiboTests(ITestOutputHelper testOutputHelper, FiboFixture fiboFixture)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Constructor");
            _fiboFixture = fiboFixture;

            memoryStream = new MemoryStream();
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            Assert.All(_fiboFixture.calc.FiboNumbers, n => Assert.NotEqual(0, n));
            Assert.DoesNotContain(0, _fiboFixture.calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            Assert.Contains(13, _fiboFixture.calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            Assert.DoesNotContain(4, _fiboFixture.calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            Assert.Equal(expectedCollection, _fiboFixture.calc.FiboNumbers);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var result = _fiboFixture.calc.IsOdd(value);
            Assert.Equal(expected,result); ;
        }



        public void Dispose()
        {
            memoryStream.Dispose();
        }
    }
}
