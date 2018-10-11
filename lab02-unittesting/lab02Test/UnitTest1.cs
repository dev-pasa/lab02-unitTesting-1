using System;
using Xunit;
using lab02_unittesting;

namespace lab02Test
{
    public class UnitTest1
    {
        //tests Withdraw method for correct outputs: 2 valid and 1 invalid inputs
        [Theory]
        [InlineData(3100, "Insufficient funds.")]
        [InlineData(500, "Withdraw success!")]
        [InlineData(-100, "Invalid withdraw amount.")]
        public void WithdrawReturnsCorrectly(int actual, string expected )
        {
            Assert.Equal(expected, Program.Withdraw(actual));
        }

        //test the Deposit method for correct output: 1 valid an 1 invalid input
        [Theory]
        [InlineData(-100, "Insufficient deposit amount.")]
        [InlineData(500, "Deposit success!")]
        public void DepositReturnsCorrectly(int actual, string expected)
        {
            Assert.Equal(expected, Program.Deposit(actual));
        }    
    }
}
