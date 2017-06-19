using AutomationFramework.Pages;
using NUnit.Framework;

namespace DemoWebApp.Tests
{
    [TestFixture]
    class LoanApplicationTests
    {
        [TestFixtureSetUp]
        public void Initialize()
        {
            Driver.Initialize();
        }

        [Test]
        public void Application_is_running()
        {
            MainPage.GoTo();
            Assert.IsTrue(MainPage.IsOn());
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
