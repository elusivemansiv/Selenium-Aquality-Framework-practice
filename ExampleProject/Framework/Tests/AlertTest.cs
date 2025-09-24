using ExampleProject.Framework;
using ExampleProject.Framework.Pages;
using NUnit.Framework;

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
            browser.HandleAlert(Aquality.Selenium.Browsers.AlertAction.Accept);
            alertPage.IsSuccessmsgDisplayed();
            
        }
    }
}
