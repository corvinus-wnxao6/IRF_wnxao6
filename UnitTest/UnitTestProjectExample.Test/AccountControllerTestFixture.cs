using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd","false"),
            TestCase("abcd@xyz.com","true"),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email,bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var result=accountController.ValidateEmail(email);

            //Assert -- megfelel-e az eredmény amit vártam
            Assert.AreEqual(result, expectedResult);
        }

        [
            Test,
            TestCase("abcd1234", false),
            TestCase("ABCD123", false),
            TestCase("abcDABCD",false),
            TestCase("abD2",false),
            TestCase("AbcdEF1234",true)
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var result = accountController.ValidatePassword(password);

            //Assert -- megfelel-e az eredmény amit vártam
            Assert.AreEqual(result, expectedResult);
        }
    }
}
