using ExampleProject.Framework;
using ExampleProject.Framework.Pages;
using NUnit.Framework;

namespace ExampleProject.Framework.Tests
{
    internal class WidgetsTest : BaseTest
    {
        [Test]
        public void widget()
        {
            var widgetPage = new WidgetsPage();
            Assert.IsTrue(widgetPage.State.IsDisplayed, "Widgets Page is not Open");
            widgetPage.ClickCard();
            widgetPage.ClickDatepickerOption();
        }
    }
}
