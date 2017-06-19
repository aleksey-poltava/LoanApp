using DemoWebApp.Tests;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public class MainPage
    {
        private static string applyButtonCentralCode = "startApplication";
        private static string h1HeaderCode = "//h1[contains(text(),'Buy want you want today')]";
        private static string h2HeaderBlock1Code = "//h2[contains(text(),'Best rates')]";
        private static string h2HeaderBlock2Code = "//h2[contains(text(),'Easy application')]";
        private static string h2HeaderBlock3Code = "//h2[contains(text(),'Quick payments')]";

        public static void ApplyNowMainBtn()
        {
            var applyNow = Driver.Instance.FindElement(By.Id(applyButtonCentralCode));
            applyNow.Click();
        }

        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.SiteRoot);
            if (!IsOn())
            {
                Driver.TestLogicFailed("Class name is: " + "Failed method is: IsOn()");
                return;
            }
            Driver.TestLogicFailed("GoTo page successfull");
        }

        public static bool IsOn()
        {
            if ((Driver.Instance.FindElement(By.XPath(h1HeaderCode)).Displayed)
                && (Driver.Instance.FindElement(By.XPath(h2HeaderBlock1Code)).Displayed)
                && (Driver.Instance.FindElement(By.XPath(h2HeaderBlock2Code)).Displayed)
                && (Driver.Instance.FindElement(By.XPath(h2HeaderBlock3Code)).Displayed))
                return true;
            return false;
        }
    }
}
