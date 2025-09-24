using AngleSharp.Html;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;

namespace ExampleProject.Framework.Pages
{
    public class ElementsPage : Form
    {
        private IButton elementCard = ElementFactory.GetButton(By.XPath("//h5[text()='Elements']"), "Elements");
        private IButton textBoxOption = ElementFactory.GetButton(By.XPath("//span[text()='Text Box']"), "Text Box");
        private ITextBox nameTextBox => ElementFactory.GetTextBox(By.Id("userName"), "FullName");
        private ITextBox emailTextBox => ElementFactory.GetTextBox(By.Id("userEmail"), "Email");

        private ITextBox currentAddressTextBox => ElementFactory.GetTextBox(By.Id("currentAddress"), "Current Address");
        private ITextBox presentAddressTextBox => ElementFactory.GetTextBox(By.Id("permanentAddress"), "Permanent Address");

        private IButton submitBtn = ElementFactory.GetButton(By.Id("submit"), "Submit");

        public ElementsPage() : base(By.ClassName("category-cards"), " Elements")
        {
        }

        public void ClickCard()
        {
            elementCard.Click();

        }

        public void ClicktextBoxOption()
        {
            textBoxOption.Click();
        }

        public void TextBox()
        {
            nameTextBox.Type("Jack");
            emailTextBox.Type("jack@gmail.com");
            currentAddressTextBox.Type("Los Santos");
            presentAddressTextBox.Type("Vice City");
            submitBtn.Click();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
