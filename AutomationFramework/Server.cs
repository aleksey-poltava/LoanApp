using TestStack.Seleno.Configuration;

namespace AutomationFramework
{
    public static class Server
    {
        public static readonly SelenoHost Instance = new SelenoHost();


        public static void Run()
        {
            Instance.Run("LoanApplicationSite", 4223);
        }
    }
}
