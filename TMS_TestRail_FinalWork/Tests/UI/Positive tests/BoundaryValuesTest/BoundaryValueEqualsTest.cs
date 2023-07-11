using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Tests.UI.Positive_tests.BoundaryValuesTest
{
    public class BoundaryValueEqualsTest : BaseTest
    {
        [Test(Description = "Boundary value test")]
        [Category("Boundary Value Test")]
        [Description("The number of entered values is 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void BoundaryValeuEquals_250_Test()
        {
            string searchProject = "The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko+1@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToProjectCategorySearch()
                .EnterDataInSearchField(searchProject);

            Thread.Sleep(5000);

            Assert.IsFalse(dashboard_SearchProject_Page.IsPresentErrorLimitDialogMessage());
        }
    }
}
