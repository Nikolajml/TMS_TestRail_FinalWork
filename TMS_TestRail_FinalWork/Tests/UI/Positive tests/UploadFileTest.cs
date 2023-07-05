using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Pages;

namespace TMS_TestRail_FinalWork.Tests.Positive_tests
{
    public class UploadFileTest : BaseTest
    {
        [Test(Description = "Successful file upload test")]
        [Description("Successful test to upload a file using the Chain of Invocation design pattern")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void UploadTest()
        {   
            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .NavigateToOverviewPage()
                .NavigateToDataManagement_Storage_Page()
                .NavigateToDataManagement_Attachments_Page()
                .UploadFile();
            
            
            Assert.True(Driver.FindElement(By.XPath("//div[@title='FileForUpload.txt']")).Displayed);
        }
    }
}
