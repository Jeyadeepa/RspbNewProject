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

namespace RspbNewProject
{
    [TestFixture]
    public class TestClass1 : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            
            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField= driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");
            Thread.Sleep(5000);
            
        }
        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {

            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");

        }
        [Test,Category("Smoke Testing")]
        public void TestMethod3()
        {

            driver.FindElement(By.XPath("(//*[@class='link--login link'])[1]")).Click();
            IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextField.SendKeys("jeyadeepa.elamaran@rspb.org.uk");

        }
    }
}
