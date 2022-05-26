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
