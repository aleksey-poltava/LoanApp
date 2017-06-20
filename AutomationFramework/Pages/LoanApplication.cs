using DemoWebApp.Tests;
using OpenQA.Selenium;

namespace AutomationFramework.Pages
{
    public static class LoanApplication
    {
        private static string h2HeaderCode = "//h2[contains(text(),'Start Loan Application')]";
        private static string firstLabelId = "FirstName";
        private static string secondLabelId = "LastName";
        private static string applyButtonClass = "btn-primary";

        public static bool IsOn()
        {
            if ((Driver.Instance.FindElement(By.XPath(h2HeaderCode)).Displayed)
                && (Driver.Instance.FindElement(By.Id(firstLabelId)).Displayed)
                && (Driver.Instance.FindElement(By.Id(secondLabelId)).Displayed)
                && (Driver.Instance.FindElement(By.ClassName(applyButtonClass)).Displayed))
                return true;
            return false;
        }
    }
}
