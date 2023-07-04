using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;

namespace TMS_TestRail_FinalWork.Tests.Positive_tests
{
    public class EntityDeletionTest : BaseTest
    {
        [Test(Description = "Successful project deletion test")]
        [Description("Successful test to delete a project using the Chain of Invocation design pattern")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void DeleteProjectTest()
        {
            string expectedSuccessDeletedMessage = "Successfully deleted the project.";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();                       

            LoginPage.SuccessfulLogin(user)
                .NavigateToOverviewPage()
                .NavigateToProjectsPage()
                .DeleteProject();
            

            Assert.That(ProjectsPage.GetSuccessDeletedMessage, Is.EqualTo(expectedSuccessDeletedMessage));
        }
    }
}
