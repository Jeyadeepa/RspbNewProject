using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RspbNewProject
{
    [TestFixture]
    public class TestCase
    {
        [Test]
        [Author("Deepa","jeyadeepa.elamaran@rspb.org.uk")]
        [Description("Login Pages")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = urlName;
                //driver.Url = "https://www.rspb.org.uk/";
                driver.FindElement(By.CssSelector("body > div.cookie-preferences > div > div:nth-child(2) > div.col-12.col-md-12.col-lg-12.cookie-preferences__default-action-wrapper > div.cookie-preferences__default-action > a")).Click();
                driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
                //IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='abcd']"));
                emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jeyadeepaelamaran\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
            
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.rspb.org.uk/");
            //list.Add("https://staging.rspb.org.uk");
            //list.Add("https://Preprod.rspb.org.uk");
            return list;
        }
    }
}
