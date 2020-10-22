using NUnit.Framework;
using PlanItTest.Pages;
using System.Threading;

namespace PlanItTest
{
    [TestFixture]
    public class ContactPageTest :BasePage

    {
        public ContactPage contactPage;


        [OneTimeSetUp]
        public void Setup()
        {
            Setup("https://jupiter.cloud.planittesting.com/");
        
          
          //  contactPage = navBar.GetContactPage();
        }


        /// <summary>
        /// Test case 1.1:
        /// 1.	From the home page go to contact page
        /// 2.	Click submit button 
        /// 3.	Validate errors
        /// 4.  Populate mandatory fields
        ///5.	Validate errors are gone
        /// </summary>
        [Test, Order(1)]
        public void ValidateMandatoryFields()
        {

            contactPage = navBar.GetContactPage();
            contactPage.ClickSubmit();
            Assert.AreEqual(contactPage.GetErrorMessage("forename"), "Forename is required");
            Assert.AreEqual(contactPage.GetErrorMessage("email"), "Email is required");
            Assert.AreEqual(contactPage.GetErrorMessage("message"), "Message is required");
            navBar.GetHomePage();

     


        }
        ///<summary>
        ///     Test case 1.2:
        /// 1.	From the home page go to contact page
        /// 2.  Populate mandatory fields
        /// 3.	Validate errors are gone
        ///</summary>
        [Test, Order(2)]
        public void EnterValidDataToMandatoryFields()
        {

            contactPage = navBar.GetContactPage();
            contactPage.Forename.SendKeys("John");
            Assert.IsFalse(contactPage.IsErrorPresent("forename"));

            contactPage.Email.SendKeys("John@test.com");
            Assert.IsFalse(contactPage.IsErrorPresent("email"));

            contactPage.Message.SendKeys("Hi How are You");
            Assert.IsFalse(contactPage.IsErrorPresent("message"));

            navBar.GetHomePage();

        }

        ///<summary>
        ///     Test case 2:
        /// 1.	From the home page go to contact page
        /// 2.	Populate mandatory fields
        /// 3.	Click submit button
        /// 4.	Validate successful submission message
        ///</summary>

        [Test, Order(3)]
        public void ValidDataToMandatoryFields()
        {

            contactPage = navBar.GetContactPage();
            contactPage.EnterDataToMandatoryFields("Jim", "Jim@test.com", "Hi How are You");
            contactPage.ClickSubmit();
            Assert.AreEqual(contactPage.waitForModeltoClose(), "pass");
            Assert.AreEqual(contactPage.SuccessMsg.Text, "Thanks Jim, we appreciate your feedback.");
            navBar.GetHomePage();
        }
        ///<summary>
        ///     Test case 3:
        ///1.	From the home page go to contact page
        ///2.	Populate all fields with invalid data
        ///3.	Validate errors
        ///     Assumptions only Email field is validate for invalid data.
        ///     I have check mannually no validation for Forename and Message

        ///</summary>
        [Test, Order(4)]
        public void InvalidDataToAllFields()
        {


            contactPage = navBar.GetContactPage();
            contactPage.EnterDataToAllFields("Shan123", "Jim@", "123SS", "Hi How are@@@@@34342533////// You");
            Assert.AreEqual(contactPage.GetErrorMessage("email"), "Please enter a valid email");
            Assert.AreEqual(contactPage.GetErrorMessage("telephone"), "Please enter a valid telephone number");
            navBar.GetHomePage();

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            TestCleanUp();
        }

      


    }
}