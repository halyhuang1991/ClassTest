using System;
using Xunit;
using test.Common;
namespace Demo1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1,2);
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(1,1);
        }
        [Fact]
        public void Test3()
        {
            string ok=Class1.GetStr();
            Assert.Equal(ok,"ok");
        }
    }
}
