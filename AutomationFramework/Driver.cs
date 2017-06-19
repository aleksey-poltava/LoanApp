using AutomationFramework.Log;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace DemoWebApp.Tests
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static bool isTestLogicFailed { get; private set; }

        public static string SiteRoot
        {
            get { return "http://localhost:40077/"; }
        }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();

            Instance.Manage().Window.Maximize();

            Logger.InitLogger();//инициализация - требуется один раз в начале

            Logger.Log.Info("Ура заработало!");
        }

        public static void Close()
        {
            Instance.Quit();
            Instance = null;
        }

        public static void TestLogicFailed(string s)
        {
            //add logging here
            isTestLogicFailed = true;
        }
    }
}
