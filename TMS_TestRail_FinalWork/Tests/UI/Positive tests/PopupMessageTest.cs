using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Models;

namespace TMS_TestRail_FinalWork.Tests.UI
{
    public class PopupMessageTest : BaseTest
    {
        [Test(Description = "Popup message display test")]
        [Description("Checking the display of the popup message")]
        [AllureOwner("User")]
        [AllureTag("Smoke")]
        [SmokeTest]
        public void PopupMessageIsDisplayTest()
        {           
            User user = new UserBuilder()
                .SetUsername("nicolas.maliavko+1@gmail.com")
                .SetPassword("Qwer_1234")
                .Build();

            LoginPage.SuccessfulLogin(user)
                .ClickToTopLogo()
                .WaitPopupMessage(); 

            Assert.That(DashboardPage.IsDispayedPopupMessage(), Is.EqualTo(true));
        }
    }
}
