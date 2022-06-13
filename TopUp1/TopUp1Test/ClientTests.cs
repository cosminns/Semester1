using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopUp1Test
{
    public class ClientTests
    {
        ClientAppDriver appDriver;

        [SetUp]
        public void Setup() 
        {
            appDriver = new ClientAppDriver();
        }

        [Test]
        public void LoginTest() 
        {
            var userNameText = appDriver.session.FindElementByAccessibilityId("userNameTextField");
            userNameText.Clear();
            userNameText.SendKeys("Adriana604");
            var passwordText = appDriver.session.FindElementByAccessibilityId("passwordTextField");
            passwordText.Clear();
            passwordText.SendKeys("Password123");
            appDriver.session.FindElementByAccessibilityId("loginButton").Click();
            var memberMenuButton = appDriver.desktopSession.FindElementByAccessibilityId("memberMenuButton");
            Assert.That(memberMenuButton, Is.Not.Null);
        }

        [TearDown]
        public void TearDown() 
        {
            appDriver.session.CloseApp();
        }
    }
}
