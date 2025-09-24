using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Utilities;
using Aquality.Selenium.Elements.Actions;
using ExampleProject.Framework;
using ExampleProject.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Tests
{
    internal class AlertsTest : BaseTest
    {
        [Test]
        public void alert()
        {
            var alertPage = new AlertPage();
            Assert.IsTrue(alertPage.State.IsDisplayed, "Alert Page is not Open");
            alertPage.ClickCard();
            alertPage.ClickAlertsOption();
            
            alertPage.ClickClickMeBtn();
            //browser.HandleAlert(Aquality.Selenium.Browsers.AlertAction.Accept);
            //browser.HandleAlert(Aquality.Selenium.Browsers.AlertAction.Decline);
            //alertPage.IsSuccessmsgDisplayed();
            //alertPage.IsSuccessmsgDisplayed2();

            var driver = AqualityServices.Browser.Driver;
            IAlert promptAlert = driver.SwitchTo().Alert();

            string name = "Mansib";
            promptAlert.SendKeys(name);
            promptAlert.Accept();

            // Verify result
            Assert.IsTrue(alertPage.IsPromptResultDisplayed(), "Prompt result message is not displayed.");
            StringAssert.Contains(name, alertPage.GetPromptResultText(), "The entered name is not displayed in the result.");


        }
    }
}
