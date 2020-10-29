using System;
using System.Threading.Tasks;
using Xunit;

namespace Damurka.Generator.Test
{
    public class ShortIdTest
    {
        [Fact]
        public void TestDefault()
        {
            var result = ShortId.Generate();
            Assert.Equal(8, result.Length);
        }

        [Fact]
        public void TestLengthSpecified()
        {
            var result = ShortId.Generate(20);
            Assert.Equal(20, result.Length);
        }

        [Fact]
        public void TestUsinglsingleLetter()
        {
            var result = ShortId.Generate(7, "a");
            Assert.Equal("aaaaaaa", result);
        }

        [Fact]
        public void TestIfAllowableCharacterNull()
        {
            Assert.ThrowsAny<InvalidOperationException>(() => ShortId.Generate(7, null));
        }

        [Fact]
        public void TestIfAllowableCharacterIsEmpty()
        {
            Assert.ThrowsAny<InvalidOperationException>(() => ShortId.Generate(7, ""));
        }

        [Fact]
        public void TestIfAllowableCharacterIsWhiteSpace()
        {
            Assert.ThrowsAny<InvalidOperationException>(() => ShortId.Generate(7, "   "));
        }

        [Fact]
        public void TestIfAllowableCharacterContainsWhiteSpace()
        {
            Assert.ThrowsAny<InvalidOperationException>(() => ShortId.Generate(7, "abc 123"));
        }

        [Fact]
        public void TestIfLengthIsZero()
        {
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => ShortId.Generate(0));
        }
    }
}
