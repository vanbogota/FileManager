using System;
using Lesson_2;
using Xunit;

namespace BankAccountTests
{
    public class UnitTest1
    {
        private readonly BankAccount _bankAccount;

        public UnitTest1()
        {
            _bankAccount = new BankAccount(100);
        }
        [Fact]
        public void Test_StringForward()
        {
            //Arrange
            string str = "12345";
            
            //Act
            var result = _bankAccount.ForwardString(str);
            
            //Assert
            Assert.Equal("54321", result);
        }
    }
}