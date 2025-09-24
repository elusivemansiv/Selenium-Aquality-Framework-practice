using AngleSharp.Dom;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExampleProject.Framework.Pages
{
    public class FormsPage : Form

    {
        private IButton elementsCard = ElementFactory.GetButton(By.XPath("//h5[text()='Forms']"), "Form card");
        private IButton practiceForm = ElementFactory.GetButton(By.XPath("//span[text()='Practice Form']"), "Practice Form");

        private ITextBox firstName = ElementFactory.GetTextBox(By.Id("firstName"), "First Name");
        private ITextBox lastName = ElementFactory.GetTextBox(By.Id("lastName"), "Last Name");
        private ITextBox userEmail = ElementFactory.GetTextBox(By.Id("userEmail"), "User Email");
        private IButton gender = ElementFactory.GetButton(By.CssSelector("label[for='gender-radio-1']"), "Male radio button");
        private ITextBox Mobile = ElementFactory.GetTextBox(By.Id("userNumber"), "Mobile number");

        private ITextBox dateOfBirthInput = ElementFactory.GetTextBox(By.Id("dateOfBirthInput"), "Date of Birth field");
        private IComboBox monthSelect = ElementFactory.GetComboBox(By.ClassName("react-datepicker__month-select"), "Month dropdown");
        private IComboBox yearSelect = ElementFactory.GetComboBox(By.ClassName("react-datepicker__year-select"), "Year dropdown");
        private IButton daySelect = ElementFactory.GetButton(By.XPath("//div[contains(@class,'react-datepicker__day')]"), "Day");


        private ITextBox subjectsInput = ElementFactory.GetTextBox(By.Id("subjectsInput"), "Subjects input");

        private IButton hobbiesCheckbox = ElementFactory.GetButton(By.CssSelector("label[for='hobbies-checkbox-3']"), "Hobbies checkbox");

        private ITextBox stateInput = ElementFactory.GetTextBox(By.Id("react-select-3-input"), "State input");
        private ITextBox cityInput = ElementFactory.GetTextBox(By.Id("react-select-4-input"), "City input");

        private ITextBox currentAddress = ElementFactory.GetTextBox(By.Id("currentAddress"), "Current Address");

        private IButton submitBtn = ElementFactory.GetButton(By.Id("submit"), "Submit Button");

        public FormsPage() : base(By.ClassName("category-cards"), "Forms Page")
        {
        }

        public void ClickCard()
        {
            elementsCard.Click();
            
        }

        public void ClickPracticeForm()
        {
            practiceForm.Click();
        }

        public void FormFill()
        {
            firstName.Type("Mansib");
            lastName.Type("Khan");
            userEmail.Type("a.mansib@a1qa.com");
            gender.Click();
            Mobile.Type("0178649238");

            dateOfBirthInput.Click();
            monthSelect.SelectByText("December");
            yearSelect.SelectByText("1999");
            ElementFactory.GetButton(By.XPath($"//div[contains(@class,'react-datepicker__day') and text()='{17}']"), $"Day {17}").Click();

            subjectsInput.SendKeys("Computer Science");
            subjectsInput.SendKeys(Keys.Enter);
            hobbiesCheckbox.Click();

            stateInput.SendKeys("Uttar Pradesh");
            stateInput.SendKeys(Keys.Enter);

            cityInput.SendKeys("Lucknow");
            cityInput.SendKeys(Keys.Enter);
            currentAddress.Type("Vice City");
            submitBtn.Click();

        }
    }
}
