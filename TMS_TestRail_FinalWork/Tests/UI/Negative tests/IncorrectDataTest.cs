using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Tests.Negative_tests
{
    public class IncorrectDataTest : BaseTest
    {
        [Test(Description = "Test with incorrect data")]
        [Description("The test uses an incorrect password for authorization")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void LoginWithIncorrectPassword()
        {
            string expectedErrorMessage = "Email/Login or Password is incorrect. Please try again.";

            User incorrectPasswordUser = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("password")
                .Build();

            LoginPage.LoginWithIncorrectCredential(incorrectPasswordUser);

            Assert.That(LoginPage.GetErrorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }
}
