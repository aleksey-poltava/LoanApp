using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationFramework.Helpers
{
    public static class HtmlElements
    {
        public static bool IsElementExists(IWebDriver driver, By by, TimeSpan timeSpan, int iterationSleepTime)
        {
            bool elementFounded = false;
            int elapsed = 0;

            while ((!elementFounded) && (elapsed < timeSpan.TotalMilliseconds))
            {
                Thread.Sleep(iterationSleepTime);
                elapsed += iterationSleepTime;

                var elements = driver.FindElements(by);
                if (elements.Count > 0)
                    elementFounded = true;

            }
            Console.WriteLine("Element founded?: " + elementFounded);
            return elementFounded;
        }
    }
}
