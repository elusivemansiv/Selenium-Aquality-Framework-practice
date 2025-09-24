using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Pages
{
    public class AlertPage : Form
    {
        private IButton alertCard = ElementFactory.GetButton(By.XPath("//h5[text()='Alerts, Frame & Windows']"), "Alerts Card");
        private IButton alertsOption = ElementFactory.GetButton(By.XPath("//span[text()='Alerts']"), "Alerts");
        private IButton clickMe => ElementFactory.GetButton(By.Id("alertButton"), "Click Button to see alert");
        private ILabel successmsglbl => ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator,
            "You clicked a button")), "Success message text");


        public AlertPage() : base(By.ClassName("category-cards"), "Alert Page")
        {
        }

        public void ClickCard()
        {
            alertCard.Click();
            
        }

        public void ClickAlertsOption()
        {
            alertsOption.Click();
        }

        public void ClickClickMeBtn() => clickMe.Click();
        public bool IsSuccessmsgDisplayed() => successmsglbl.State.IsDisplayed;
    }
}
