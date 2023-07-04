using Allure.Commons;
using AngleSharp;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;
using TMS_TestRail_FinalWork.Utilities.Configuration;

namespace TMS_TestRail_FinalWork.Tests
{
    public class EntityCreationTest : BaseTest
    {
        [Test(Description = "Successful project creation test")]
        [Description("Successful test to create a project using the Chain of Invocation and Value of Objects design patterns")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]        
        public void CreateProjectTest()
        {
            string expectedSuccessCreatedMessage = "Successfully added the new project.";

            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            Project project = new ProjectBuilder()
                .SetProjectName("Test Project 1")
                .SetProjectAnnouncement("The project was created for testing")
                .Build();                      

            LoginPage.SuccessfulLogin(user)
                .AddProject()
                .CreateProject(project);                

            Assert.That(ProjectsPage.GetSuccessCreatedMessage, Is.EqualTo(expectedSuccessCreatedMessage));             
        }
    }
}
