using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RspbNewProject.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init()
        {
            var driver = new ChromeDriver();
            //var Cookies = this.driver.Manage
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.rspb.org.uk/";
            driver.FindElement(By.CssSelector("body > div.cookie-preferences > div > div:nth-child(2) > div.col-12.col-md-12.col-lg-12.cookie-preferences__default-action-wrapper > div.cookie-preferences__default-action > a")).Click();
            //driver.FindElement(By.CssSelector("(//*[@class='button-text cookie-preferences__default-action__button'])")).Click();
            return driver;
        }

    }
}
