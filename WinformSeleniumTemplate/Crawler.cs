using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformSeleniumTemplate
{
    internal class Crawler
    {
        ChromeDriverService chromeDriverService;
        ChromeDriver chromeDriver;

        public Crawler()
        {
            initDriver();

        }

        private void initDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");

            chromeDriverService = ChromeDriverService.CreateDefaultService();

            // hide chromedriver.exe 
            //chromeDriverService.HideCommandPromptWindow = true;

            chromeDriver = new ChromeDriver(chromeDriverService, options);
            // without line below, I got no such element ~~ error. So I need it! 
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }


        public void doWork()
        {
            chromeDriver.Navigate().GoToUrl("https://google.com");
        }



    }
}
