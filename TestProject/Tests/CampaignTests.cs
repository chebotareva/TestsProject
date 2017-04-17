using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class CampaignTests : Helper
    {
        [TestMethod]
        public void ContactUsSubmitTest()
        {
            SwitchToContactUsForm(CampaignURLs.campaignStage);

            FillRequiredFieldsAndSubmitContactUsForm(ContactUsData.firstName, ContactUsData.lastName, ContactUsData.email);

            string actualSubmitDoneMessage = driver.FindElement(By.ClassName(CampaignLocators.submitMessageClassName), 60).Text;
            string expectedSubmitDoneMessage = "Thank You";

            Assert.AreEqual(expectedSubmitDoneMessage, actualSubmitDoneMessage);
        }

    }
}
