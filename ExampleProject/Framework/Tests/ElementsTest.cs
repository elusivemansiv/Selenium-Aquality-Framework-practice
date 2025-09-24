using ExampleProject.Framework;
using ExampleProject.Framework.Pages;
using NUnit.Framework;

namespace ExampleProject.Framework.Tests
{
    internal class ElementsTest : BaseTest
    {
        [Test]
        public void Elements()
        {
            var elementPage = new ElementsPage();
            Assert.IsTrue(elementPage.State.IsDisplayed, "Element Page is not Open");
            elementPage.ClickCard();
            elementPage.ClicktextBoxOption();
            elementPage.TextBox();
        }
    }
}
