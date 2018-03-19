using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;
using System;
using Xunit;

namespace xUnitSpecFlowChrome
{
    public class Class1 : IDisposable
    {
        protected RemoteWebDriver driver;

        public Class1()
        {

        }

        public void Dispose()
        {
            //driver.Close();
            driver.Quit();
            driver.Dispose();
            driver = null;
        }

        [Fact(DisplayName = "Headless Chrome")]
        public void ChromeTest()
        {
            var options = new ChromeOptions();
            options.AddArguments("--headless", "start-maximized", "--disable-gpu", "--disable-extensions", "no-sandbox");

            options.BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";

            var svc = ChromeDriverService.CreateDefaultService();
            svc.EnableVerboseLogging = true;

            var url = svc.ServiceUrl;
            svc.Start();

            driver = new ChromeDriver(svc, options);

            driver.Navigate().GoToUrl("http://www.daringfireball.net");

            var title = driver.Title;

            driver.GetScreenshot().SaveAsFile(@"c:\chromeshot.jpg", ScreenshotImageFormat.Jpeg);
        }

        [Fact(DisplayName = "PhantomJS")]
        public void PhantomTest()
        {
            driver = new PhantomJSDriver();

            driver.Navigate().GoToUrl("http://www.daringfireball.net");
            var title = driver.Title;

            driver.GetScreenshot().SaveAsFile(@"c:\phantomshot.jpg", ScreenshotImageFormat.Jpeg);
        }
    }
}
