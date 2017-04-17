using OpenQA.Selenium;

namespace TestProject
{
    public class Helper : BaseTest
    {
        public void Type(By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);
        }

        public void SwitchToContactUsForm(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.FindElement(By.ClassName(CampaignLocators.contactUsButtonClassName), 30).Click();
            IWebElement contactUsIFrame = driver.FindElement(By.ClassName(CampaignLocators.contactUsIFrameClassName), 30);
            driver.SwitchTo().Frame(contactUsIFrame);
        }

        public void FillRequiredFieldsAndSubmitContactUsForm(string firstName, string lastName, string email)
        {
            Type(By.Id(CampaignLocators.firstNameInputId), firstName);
            Type(By.Id(CampaignLocators.lastNameInputId), lastName);
            Type(By.Id(CampaignLocators.emailInputId), email);

            driver.FindElement(By.Id(CampaignLocators.submitButtonId)).Click();
        }
    }
}
