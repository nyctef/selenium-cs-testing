using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace testing
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            using var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000");

            Assert.AreEqual("Home Page - website", driver.Title);

            var heading = driver.FindElement(By.XPath("//*[contains(text(),'Welcom')]"));
            Console.WriteLine(heading);
        }
    }
}