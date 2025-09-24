using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Pages
{
    public class WidgetsPage : Form
    {
        private IButton widgetCard = ElementFactory.GetButton(By.XPath("//h5[text()='Widgets']"), "Widgets");
        private IButton datepickerOption = ElementFactory.GetButton(By.XPath("//span[text()='Date Picker']"), "Date Picker");

        public WidgetsPage() : base(By.ClassName("category-cards"), "Widget Page")
        {
        }

        public void ClickCard()
        {
            widgetCard.Click();

        }

        public void ClickDatepickerOption()
        {
            datepickerOption.Click();
        }
    }
}
