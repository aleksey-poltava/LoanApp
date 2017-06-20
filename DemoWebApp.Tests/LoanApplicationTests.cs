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

        [Test]
        public void Can_Access_Loan_Application_Page()
        {
            MainPage.GoTo();
            MainPage.ApplyNowMainBtn();
            Assert.IsTrue(LoanApplication.IsOn());
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
