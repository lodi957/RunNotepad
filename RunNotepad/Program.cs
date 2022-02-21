using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunNotepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> notepadSession;
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", @"C:\Program Files\Astera Software\Centerprise Data Integrator 8\Centerprise.exe");
            try
            {
                notepadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return;
            }
            if (notepadSession != null)
            {
                notepadSession.FindElementByName("OK").Click();
                notepadSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                IEnumerable<AppiumWebElement> elementsOne = notepadSession.FindElementsByAccessibilityId("ToolBarAreaTop");
                
            }
        }
    }
}
