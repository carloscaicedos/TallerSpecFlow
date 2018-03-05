using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taller02SpecFlow
{
    [Binding]
    public class HU002_CreateUserSteps
    {
        private IWebDriver driver = new ChromeDriver();

        [Given(@"I acces to home page ""(.*)""")]
        public void GivenIAccesToHomePage(string homePage)
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

        [When(@"I enter the Id ""(.*)""")]
        public void WhenIEnterTheId(int id)
        {
            IWebElement textBoxId = driver.FindElement(By.Name("Identificacion"));
            textBoxId.Clear();
            textBoxId.SendKeys(id.ToString());
        }

        [When(@"I enter the name ""(.*)""")]
        public void WhenIEnterTheName(string name)
        {
            IWebElement textBoxName = driver.FindElement(By.Name("RazonSocial"));
            textBoxName.Clear();
            textBoxName.SendKeys(name);
        }

        [When(@"I enter the city ""(.*)""")]
        public void WhenIEnterTheCity(string city)
        {
            IWebElement textBoxCity = driver.FindElement(By.Name("Ciudad"));
            textBoxCity.Clear();
            textBoxCity.SendKeys(city);
        }

        [When(@"I enter the type client ""(.*)""")]
        public void WhenIEnterTheTypeClient(string typeClient)
        {
            IWebElement textBoxTypeClient = driver.FindElement(By.Name("TipoCliente"));
            textBoxTypeClient.Clear();
            textBoxTypeClient.SendKeys(typeClient);
        }

        [When(@"I enter the risk level ""(.*)""")]
        public void WhenIEnterTheRiskLevel(string riskLevel)
        {
            IWebElement textBoxRiskLevel = driver.FindElement(By.Name("NivelRiesgo"));
            textBoxRiskLevel.Clear();
            textBoxRiskLevel.SendKeys(riskLevel);
        }

        [When(@"I create the user")]
        public void WhenICreateTheUser()
        {
            IWebElement btnCreate = driver.FindElement(By.Id("btnCreate"));
            btnCreate.Click();
        }

        [Then(@"I valid that the customer list contain the id client ""(.*)""")]
        public void ThenIValidThatTheCustomerListContainTheIdClientWithName(int customerId)
        {
            IWebElement idLabel = driver.FindElement(By.Id(customerId.ToString()));
            string result = idLabel.Text;

            Assert.AreEqual(customerId.ToString(), result, "Error en la prueba.");
        }

        [Then(@"finish the test")]
        public void ThenFinishTheTest()
        {
            driver.Quit();
        }
    }
}
