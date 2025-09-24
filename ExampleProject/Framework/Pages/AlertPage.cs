using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Pages
{
    public class AlertPage : Form
    {
        private IButton alertCard = ElementFactory.GetButton(By.XPath("//h5[text()='Alerts, Frame & Windows']"), "Alerts Card");
        private IButton alertsOption = ElementFactory.GetButton(By.XPath("//span[text()='Alerts']"), "Alerts");
        //private IButton clickMe => ElementFactory.GetButton(By.Id("alertButton"), "Click Button to see alert");
        //private IButton clickMe2 => ElementFactory.GetButton(By.Id("confirmButton"), "On button click, confirm box will appear");


        //private ILabel successmsglbl => ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator,
        //    "You clicked a button")), "Success message text");

        //private ILabel successmsglbl2 => ElementFactory.GetLabel(By.XPath(string.Format(LocatorConstants.PreciseTextLocator,
        //    "Do You confirm action")), "Success message text");

        private IButton promptButton = ElementFactory.GetButton(By.Id("promtButton"), "Prompt alert button");

        private ILabel promptResult = ElementFactory.GetLabel(By.Id("promptResult"), "Prompt result text");


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

        public void ClickClickMeBtn()
        {
            //clickMe.Click();
            //clickMe2.Click();
            promptButton.Click();
        }
        //public bool IsSuccessmsgDisplayed() => successmsglbl.State.IsDisplayed;

        //public bool IsSuccessmsgDisplayed2() => successmsglbl2.State.IsDisplayed;

     
        public bool IsPromptResultDisplayed() => promptResult.State.IsDisplayed;

        public string GetPromptResultText() => promptResult.GetText();
    }
}
