using BankApplicationTDD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankApplicationTDD.Tests
{
    public class BankAccountCreationTests
    {

        private readonly BankAccountManager _sut = new BankAccountManager();
        [Fact]
        public void UserCreatesBankAccount_WithCorrectCredentials_ReturnsTrue()
        {
            //A
            var sut = new BankApplicationTDD.BankAccountManager();
            bool expected = true;

            //A
            (bool isCreated, BankAccount account) = sut.CreateAccount("Oscar", 500);

            //A
            Assert.Equal(isCreated, expected);
        }

        [Theory]
        [InlineData("Oscar", 500, true)]
        [InlineData("", 500, false)]
        [InlineData("Robin",-500, false)]
        [InlineData("Robert", 5000000000, true)]
        public void MultipleAccountCreations_WithValidAndInvalidCredentials_ReturnsExpected(string name, double balance, bool expected)
        {
            //A
            (bool isSucessfullyCreated, BankAccount account) = _sut.CreateAccount(name, balance);
            //A
            Assert.Equal(isSucessfullyCreated, expected);
        }

        [Theory]
        [InlineData(2929292, 500, -400, true)]
        [InlineData(1412321, 1000,200, true)]
        [InlineData(0, 5, 4, false)]
        [InlineData(1231231, -200, -200, false)]
        [InlineData(null, 200, 200, false)]
        [InlineData(1412312, 1000, 0, false)]

        public void UserInsertsOrWithdraws_Balance_BasedOn_CurrentBalance_AsRestriction_ReturnsExpectedOperationSuccessStatus(int? bankAccountNumber, double currentBalance, double changeAmount, bool expected)
        {
            //A

            var userBankAccount = _sut.GetBankAccount(bankAccountNumber.Value);

            (bool success, double bankBalanceChange, double totalInAccount) = _sut.InsertsOrWithdraws(userBankAccount, currentBalance, changeAmount);

            //
            Assert.Equal(expected, success);

        }
    }
}
