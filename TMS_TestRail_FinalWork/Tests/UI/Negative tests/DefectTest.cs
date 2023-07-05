using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;

namespace TMS_TestRail_FinalWork.Tests.UI.Negative_tests
{
    public class DefectTest : BaseTest
    {
        [Test(Description = "Defect reproducing test")]
        [Description("When creating a user, the required field with email was invalide data")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void DefectCreateUserTest()
        {
            string expectedSuccessCreateUserMessage = "Successfully added the new user and sent an invitation email.";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            User userForCreate = new UserBuilder()
                .SetUsername("Oleg")
                .SetEmail("test_user")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToOverviewPage()
                .NavigateToUserAndRolesPage()
                .NavigateToAddUserPage()
                .CreateUser(userForCreate);

            Assert.That(ProjectsPage.GetSuccessCreateProjectMessage, Is.EqualTo(expectedSuccessCreateUserMessage));
        }
    }
}
