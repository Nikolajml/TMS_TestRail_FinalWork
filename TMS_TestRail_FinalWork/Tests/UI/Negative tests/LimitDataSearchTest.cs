using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;

namespace TMS_TestRail_FinalWork.Tests.Negative_tests
{
    public class LimitDataSearchTest : BaseTest
    {
        [Test(Description = "Test for input data exceeding the allowable")]
        [Description("In the search field on the Dashboard page, data is entered that exceeds the allowable (more than 250 characters)")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void LimitDataSearchQueryTest()
        {
            string enterData = "qqq123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789011";
            string expectedErrorMessage = "Field Query is too long (250 characters at most).";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .EnterDataInSearchField(enterData);

            Assert.That(DashboardPage.GetErrorLimitDialogMessage, Is.EqualTo(expectedErrorMessage));
        }
    }
}
