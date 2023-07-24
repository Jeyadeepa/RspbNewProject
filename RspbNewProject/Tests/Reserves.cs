﻿using NUnit.Framework;
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
    public class Reserves : BaseTest
    {
        //private IWebElement dropdown;

        [Test, Category("Smoke Testing")]
        public void VisitAReserve()
        {
            try
            {
                IWebElement dropdown = driver.FindElement(By.XPath("//a[normalize-space()='Days out']"));
                Actions action = new Actions(driver);
                action.MoveToElement(dropdown).Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Visit a reserve']"))).Click().Perform();
                action.MoveToElement(driver.FindElement(By.XPath("//a[@href='/days-out/reserves/arne']"))).Click().Perform();
                Thread.Sleep(5000);
                Assert.True(driver.FindElement(By.CssSelector("h1[class='title font-superior']")).Text.Contains("Arne"));
                string content = driver.FindElement(By.CssSelector("h1[class='title font-superior']")).Text;
                Assert.IsTrue(content.Contains("Arne"));
                Thread.Sleep(5000);
                driver.Close();
            }
            catch (Exception e)
            {
                ITakesScreenshot tr = driver as ITakesScreenshot;
                Screenshot screenshot = tr.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\TejasviVatsavayi\\source\\repos\\RspbNewProject\\RspbNewProject\\Screenshots\\Screenshot.jpeg",ScreenshotImageFormat.Jpeg);
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