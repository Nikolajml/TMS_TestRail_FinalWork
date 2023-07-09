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
    public class BoundaryValueMoreTest : BaseTest
    {
        [Test(Description = "Limit value test")]
        [Category("Boundary Value Test")]
        [Description("The number of entered values exceed 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void BoundaryValeuMore_250_Test()
        {
            string searchProject = "The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 /";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko+1@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToProjectCategorySearch()
                .EnterDataInSearchField(searchProject)
                .WaitDialogWindow();

            Assert.IsTrue(dashboard_SearchProject_Page.IsPresentErrorLimitDialogMessage());
        }
    }
}
