using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Tests.UI.Positive_tests
{
    public class DialogWindowTest : BaseTest
    {
        [Test(Description = "Dialog window display test")]
        [Description("Checking the display of the dialog window")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void DialogWindowIsDisplayTest()
        {
            string expectedTitle = "Configure JIRA Integration";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko+1@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToOverviewPage()
                .NavigateToIntegrationPage()
                .ClickToConfigureIntegrationButton();                

            Assert.That(integrationPage.GetDialogTitle, Is.EqualTo(expectedTitle));
        }
    }
}
