using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SpecFlowProject2.Pages
{
    public class popuppage
    {
        private AppiumDriver<AndroidElement> driver;

        public popuppage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
        By yes = By.ClassName("android.view.ViewGroup");
        By ok = By.ClassName("android.widget.TextView");
        By okk = By.XPath("//android.widget.TextView[@content-desc=\"NudgingArchiveDialogConfirm\"]");
        By gotitbutton = By.XPath("//android.widget.TextView[@content-desc=\"NudgingTipConfirmButton\"]");
       
        public void popup()//used to handle popups
        {
            if (driver.FindElementByClassName("android.view.ViewGroup").Displayed)
            {
                driver.FindElement(yes).Click();
            }
            else
            {
                driver.FindElement(ok).Click();
            }
            AndroidElement yess = driver.FindElement(By.ClassName("android.view.ViewGroup"));
            yess.Click();


        }
        public void Guidingtips(string p0)
        {
            driver.FindElement(okk).Click();
        }
        public void Button(string p0)
        {
            driver.FindElement(gotitbutton).Click();
        }
        public void validategotit(string p0)
        {
         AndroidElement gotItButton = driver.FindElementByXPath("//android.widget.TextView[@content-desc='NudgingTipConfirmButton']");
         bool isGotItButtonEnabled = gotItButton.Enabled;
         Assert.IsTrue(isGotItButtonEnabled, "'Got it' button is not enabled on the 'Music program' nudging dialog.");
        }



        public void validateBacktotips(string p0)

            {
                AndroidElement backToTipsButton = driver.FindElementByXPath("//android.widget.TextView[@content-desc='NudgingTipBackToArchiveButton']");
                bool isBackToTipsButtonEnabled = backToTipsButton.Enabled;

                Assert.IsTrue(isBackToTipsButtonEnabled, "'Back to tips' button is not enabled on the 'Music program' nudging dialog.");
            }
        
    }
}
