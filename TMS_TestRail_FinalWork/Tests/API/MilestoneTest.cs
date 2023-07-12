using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Tests.API
{
    public class MilestoneTest : BaseApiTest
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        [Test]
        public void AddMilestoneTest()
        {
            var expectedMilestone = new Milestone();
            expectedMilestone.Name = "Milestone";
            expectedMilestone.Description = "Test";
            
            _logger.Info("Expected Milestone: " + expectedMilestone);

            var actualMilestone = _milestoneService.AddAsMilestone(expectedMilestone, 5);
            _logger.Info("Actual Milestone: " + actualMilestone.ToString());

            Console.WriteLine($"Milestone Id: {actualMilestone.Id}");

            Assert.AreEqual(expectedMilestone.Name, actualMilestone.Name);
        }

        [Test]
        public void GetInvalidMilestoneTest()
        {
            var actualMilestone = _milestoneService.GetMilestoneAsync(0);
            _logger.Info("Actual Milestone: " + actualMilestone.ToString());                        

            Assert.AreEqual(HttpStatusCode.BadRequest.ToString(), actualMilestone.Result.StatusCode.ToString());
        }
    }
}
