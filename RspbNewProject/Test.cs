using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace RspbNewProject
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
             driver.Manage().Window.Maximize();

        }

        [Test]
        public void TestMethod()
        {
            //driver.Url = "https://www.rspb.org.uk/";
            driver.Url = "http://rspb-frontend-app-test-author.azurewebsites.net/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            //driver.Close();

        }
        //[TearDown]
        //public void CloseBrowser()
        //{

        //}
    }
}
