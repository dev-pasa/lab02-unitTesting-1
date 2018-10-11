using System;
using Xunit;
using lab02_unittesting;

namespace lab02Test
{
    public class UnitTest1
    {
        [Fact]
        public void NotEnoughFundsReturned()
        {
            Assert.Equal("Insufficient funds.", Program.Withdraw(3100));
        }

        [Fact]
        public void SuccessReturned()
        {
            Assert.Equal("Withdraw success!", Program.Withdraw(500));
        }

        [Fact]
        public void InvalidWithdrawReturned()
        {
            Assert.Equal("Invalid withdraw amount.", Program.Withdraw(-100));
        }


    }
}
