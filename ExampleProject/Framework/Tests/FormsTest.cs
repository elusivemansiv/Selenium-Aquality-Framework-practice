using ExampleProject.Framework;
using ExampleProject.Framework.Pages;
using NUnit.Framework;

namespace ExampleProject.Framework.Tests
{
    internal class FormsTest : BaseTest
    {
        [Test]
        public void Forms()
        {
            var formsPage = new FormsPage();
            Assert.IsTrue(formsPage.State.IsDisplayed, "Form Page is not Open");
            formsPage.ClickCard();
            formsPage.ClickPracticeForm();
            formsPage.FormFill();
        }
    }
}
