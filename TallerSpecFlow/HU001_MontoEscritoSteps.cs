using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TallerSpecFlow
{
    [Binding]
    public class HU001_MontoEscritoSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"I access to home page ""(.*)""")]
        public void GivenIAccessToHomePage(string homePage)
        {
            driver.Url = homePage;
            driver.Navigate();
        }
        
        [Given(@"I select the option ""(.*)""")]
        public void GivenISelectTheOption(string menuOption)
        {
            IWebElement option = driver.FindElement(By.LinkText(menuOption));
            option.Click();
        }
        
        [When(@"I want to convert the number ""(.*)""")]
        public void WhenIWantToConvertTheNumber(int number)
        {
            IWebElement textBox = driver.FindElement(By.Id("txtMonto"));
            textBox.Clear();
            textBox.SendKeys(number.ToString());
        }
        
        [When(@"I convert the number")]
        public void WhenIConvertTheNumber()
        {
            IWebElement btnConvert = driver.FindElement(By.Id("Convertir"));
            btnConvert.Click();
        }
        
        [Then(@"I verfiy the result is equal to ""(.*)""")]
        public void ThenIVerfiyTheResultIsEqualTo(string expectedValue)
        {
            IWebElement lblResult = driver.FindElement(By.Id("MontoEscrito"));
            string result = lblResult.Text;

            Assert.AreEqual(expectedValue, result);
        }

        [Then(@"finifh the test")]
        public void ThenFinifhTheTest()
        {
            driver.Close();
            driver.Dispose();
            driver = null;
        }
    }
}
