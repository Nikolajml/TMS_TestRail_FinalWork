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
using TMS_TestRail_FinalWork.Clients;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Services;
using TMS_TestRail_FinalWork.Utilities.Helpers;

namespace TMS_TestRail_FinalWork.Tests.API
{
    public class UserTestApi : BaseApiTest
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
                        
        [Test(Description = "NFE GET api_test")]
        [Description("Get user using valid data")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        [Category("API")]
        public void GetValidUserTest()
        {
            var actualUser = _userService.GetAsUser(1);
            _logger.Info("Actual User: " + actualUser.ToString());                        

            Console.WriteLine("Username: " + actualUser.Username);
            Console.WriteLine("Email: " + actualUser.Email);

            Assert.AreEqual(1, actualUser.Id);
            Assert.AreEqual("Nicolas Maliavko", actualUser.Username);
        }                
    }
}
