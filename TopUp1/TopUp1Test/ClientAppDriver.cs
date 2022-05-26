using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1Test
{
    public class ClientAppDriver
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string TestApp = @"D:\UCN\ProjectSem1\Semester1\TopUp1\TopUp1GUI\bin\Debug\net6.0-windows\TopUp1GUI.exe";
     
        public WindowsDriver<WindowsElement> session;
        public WindowsDriver<WindowsElement> desktopSession;

        public ClientAppDriver()
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", TestApp);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("platformName", "Windows");

            session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), options);

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

            AppiumOptions optionsDesktop = new AppiumOptions();
            optionsDesktop.AddAdditionalCapability("app", "Root");
            optionsDesktop.AddAdditionalCapability("deviceName", "WindowsPC");
            optionsDesktop.AddAdditionalCapability("ms:experimental-webdriver", true);
            desktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), optionsDesktop);
        }
    }
}