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
using RspbNewProject.Utilities;



namespace RspbNewProject
{
    [TestFixture]
    public class ParallelTesting 
    {
        IWebDriver _driver;
        [Test,Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            
            var driver= new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField= driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();
            
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {

            var driver = new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {

            var driver = new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {

            var driver = new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {

            var driver = new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {

            var driver = new BrowserUtility().Init();
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            driver.Close();

        }



    }
}
