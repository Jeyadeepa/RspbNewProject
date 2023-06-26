using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RspbNewProject.BaseClass;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace RspbNewProject
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        
        [Test,Order(0),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.rspb.org.uk/";
            driver.FindElement(By.CssSelector("body > div.cookie-preferences > div > div:nth-child(2) > div.col-12.col-md-12.col-lg-12.cookie-preferences__default-action-wrapper > div.cookie-preferences__default-action > a")).Click();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            driver.Close();

        }

        [Test,Order(2),Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.rspb.org.uk/";
            driver.FindElement(By.CssSelector("body > div.cookie-preferences > div > div:nth-child(2) > div.col-12.col-md-12.col-lg-12.cookie-preferences__default-action-wrapper > div.cookie-preferences__default-action > a")).Click();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            driver.Close();

        }

        [Test, Order(1),Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.rspb.org.uk/";
            driver.FindElement(By.CssSelector("body > div.cookie-preferences > div > div:nth-child(2) > div.col-12.col-md-12.col-lg-12.cookie-preferences__default-action-wrapper > div.cookie-preferences__default-action > a")).Click();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            driver.Close();

        }

    }
}
