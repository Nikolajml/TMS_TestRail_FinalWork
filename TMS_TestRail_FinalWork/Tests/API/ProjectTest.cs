using Bogus.Bson;
using Newtonsoft.Json.Linq;
using NLog;
using NUnit.Allure.Attributes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Services;
using TMS_TestRail_FinalWork.Utilities.Configuration;
using TMS_TestRail_FinalWork.Utilities.Helpers;

namespace TMS_TestRail_FinalWork.Tests.API
{
    public class ProjectTest : BaseApiTest
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        [Test(Description = "NFE POST api_test")]
        [Description("Add project using all required data")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        [Category("API")]
        public void AddProjectTest()
        {
            var expectedProject = new Project();
            expectedProject.Name = "Test Project API";
            expectedProject.Announcement = "Project was added with required data";
            _logger.Info("Expected Project: " + expectedProject);

            var actualProject = _projectService.AddAsProject(expectedProject);
            _logger.Info("Actual Project: " + actualProject.ToString());

            Console.WriteLine($"Project Id: {actualProject.Id}");


            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedProject.Name, actualProject.Name);
                Assert.AreEqual(expectedProject.Announcement, actualProject.Announcement);
            });

            
        }

        [Test(Description = "AFE GET api_test")]
        [Description("Get project using incorrect data (Id)")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        [Category("API")]
        public void GetInvalidProjectTest()
        {
            var actualProject = _projectService.GetProjectAsync(0);
            _logger.Info("Actual Project: " + actualProject.ToString());

            Assert.AreEqual(HttpStatusCode.BadRequest, actualProject.Result.StatusCode);
        }           
    }            
}
