using System;
using Xunit;

namespace Learning_CSharp.Tests
{
    public class MyMathTests
    {
        [Fact]
        public void FiveToThePowerOfTwoIsTen()
        {
            Assert.Equal(25, MyMath.Power(5, 2));
        }

        [Fact]
        public void TwoToThePowerOfEightIs()
        {
            Assert.Equal(256, MyMath.Power(2, 8));
        }

        [Fact]
        public void TenToThePowerOfFiveIsOneHundrenThousand()
        {
            Assert.Equal(100000, MyMath.Power(10, 5));
        }
    }
}
