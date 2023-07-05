using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TMS_TestRail_FinalWork.Tests.Positive_tests
{
    public class LimitValueTest : BaseTest
    {        
        [Test(Description = "Limit value test")]
        [Description("The number of entered values does not exceed 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]        
        public void NotExceedingLimitValuesTest()
        {
            string searchProject = "The number of entered values is 34";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToProjectCategorySearch()
                .EnterDataInSearchField(searchProject);                        

            Assert.IsFalse(dashboard_SearchProject_Page.IsPresentErrorLimitDialogMessage());
        }

        [Test(Description = "Limit value test")]        
        [Description("The number of entered values is 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]        
        public void NumberOfValuesEqualsBoundsTest()
        {
            string searchProject = "The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250The number of entered 250";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToProjectCategorySearch()
                .EnterDataInSearchField(searchProject);

            Assert.IsFalse(dashboard_SearchProject_Page.IsPresentErrorLimitDialogMessage());
        }


        [Test(Description = "Limit value test")]
        [Description("The number of entered values exceed 250")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]       
        public void ExceedingLimitValuesTest()
        {
            string searchProject = "The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 / The number of entered measurements exceed 250 /";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
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
