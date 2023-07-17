using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RspbNewProject.BaseClass;
using RspbNewProject.pageObjects;
using System;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;
using static System.Net.Mime.MediaTypeNames;

namespace RspbNewProject
{
    [TestFixture]
    public class Demo : BaseTest
    {
        //private IWebElement dropdown;

        [Test, Category("Smoke Testing")]
        public void PressRel()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Demo']"));
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Press release']"))).Click().Perform();
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title']")).Text.Contains("Charity calls on Scottish Government to deliver on nature ambitions"));
                string content = driver.FindElement(By.CssSelector("h1[class='title']")).Text;
                Assert.IsTrue(content.Contains("Charity calls on Scottish Government to deliver on nature ambitions"));
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jeyadeepaelamaran\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshots.jpeg", ScreenshotImageFormat.Jpeg);
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
        [Test, Category("Smoke Testing")]
        public void News()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Demo']"));
                //HomePage homePage = new HomePage(GetDriver());
                //homePage.Demo();
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='News']"))).Click().Perform();
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title']")).Text.Contains("Bycatch is a conservation success story ‘waiting to happen’"));
                string content = driver.FindElement(By.CssSelector("h1[class='title']")).Text;
                Assert.IsTrue(content.Contains("Bycatch is a conservation success story ‘waiting to happen’"));
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jeyadeepaelamaran\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshots.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
                //Tejasvi
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
        [Test, Category("Smoke Testing")]
        public void Activity()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Demo']"));
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Activity']"))).Click().Perform();
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title']")).Text.Contains("Activity"));
                string content = driver.FindElement(By.CssSelector("h1[class='title']")).Text;
                Assert.IsTrue(content.Contains("Activity"));
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jeyadeepaelamaran\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshots.jpeg", ScreenshotImageFormat.Jpeg);
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

        [Test, Category("Smoke Testing")]
        public void Advice()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Demo']"));
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Advice']"))).Click().Perform();
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title']")).Text.Contains("Bring back Ice Age antelope"));
                string content = driver.FindElement(By.CssSelector("h1[class='title']")).Text;
                Assert.IsTrue(content.Contains("Bring back Ice Age antelope"));
                Thread.Sleep(5000);
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\jeyadeepaelamaran\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshots.jpeg", ScreenshotImageFormat.Jpeg);
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

        //Sushma 
        [Test, Category("Smoke Testing")]
        public void Feature()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Demo']"));
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Feature']"))).Click().Perform();
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title']")).Text.Contains("Bycatch"));
                string content = driver.FindElement(By.CssSelector("h1[class='title']")).Text;
                Assert.IsTrue(content.Contains("Bycatch"));
                Thread.Sleep(5000);
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\sushmanagendranath\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshot.jpeg", ScreenshotImageFormat.Jpeg);
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



    }
}
