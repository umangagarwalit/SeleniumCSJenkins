using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumAutomation
{
    public class SeleniumTest
    {
        
        [Test]
        public void Test1()
        {
            //Launch the chrome browser

            string driverPath = @"C:\Users\umang\source\repos\SeleniumCSJenkins\SeleniumCSJenkins\drivers\";
            IWebDriver driver = new ChromeDriver(driverPath);
           

            //Set the wait for 1sec
            Thread.Sleep(1000);
            
            //Launch the parabank app
            driver.Url = "https://parabank.parasoft.com/parabank/index.htm";

            Thread.Sleep(1000);

            //Verify the page title
            string expectedResult = "ParaBank | Welcome | Online Banking";
            string actualResult = driver.Title;

            Assert.That(actualResult, Is.EqualTo(expectedResult));

            Console.WriteLine(driver.Title);

            Thread.Sleep(1000);

            //Close the chrome browser
            driver.Quit();
            

        }


    }
}