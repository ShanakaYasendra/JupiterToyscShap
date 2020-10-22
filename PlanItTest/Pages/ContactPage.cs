using OpenQA.Selenium;

using OpenQA.Selenium.Support.PageObjects;
using System;
using PlanItTest.Util;
using System.Threading;

namespace PlanItTest.Pages
{
    public class ContactPage : BasePage
    {
        private new readonly IWebDriver driver;

      public ElementHelper elementHelper;

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            elementHelper = new ElementHelper(driver);
          //  PageFactory.InitElements(driver, this);

        }
       
        public IWebElement Forename => elementHelper.GetElementByID("forename");
        public IWebElement Surname => elementHelper.GetElementByID("surname");
        public IWebElement Email => elementHelper.GetElementByID("email");
        public IWebElement Telephone => elementHelper.GetElementByID("telephone");
        public IWebElement Message => elementHelper.GetElementByID("message");
        public IWebElement Submitbtn => elementHelper.GetElementByXPath("//a[contains(@class,'btn-contact btn btn-primary')]");
        public IWebElement SuccessMsg => elementHelper.GetElementByXPath("//div[contains(@class,'alert alert-success')]");
        public IWebElement Modal => elementHelper.GetElementByCss(".modal - body");
   

        public void EnterDataToMandatoryFields(string forename, string email, string message)
        {
           
            Forename.Clear();
            Forename.SendKeys(forename);
            Email.Clear();
            Email.SendKeys(email);
            Message.Clear();
            Message.SendKeys(message);

        }

        public void EnterDataToAllFields(string forename, string email, string telno, string message)
        {
           
            Forename.Clear();
            Forename.SendKeys(forename);
            Email.Clear();
            Email.SendKeys(email);
            Telephone.Clear();
            Telephone.SendKeys(telno);
            Message.Clear();
            Message.SendKeys(message);

        }


        public void ClickSubmit()
        {
            
           
            Submitbtn.Click();
        }

        public string GetErrorMessage(string fieldName)
        {
            string element = fieldName + "-err";
            return GetTextValue(element);
        }

        public bool IsErrorPresent(string fieldName)
        {
            string element = fieldName + "-err";
            return IsElementDisplay(element);
        }

        public string waitForModeltoClose()
        {

            int count = 0;

            bool isDisplay = false;
            //elementHelper = new ElementHelper(driver);
            while ((isDisplay.Equals(false))||(count<50))
            {
               int countw = driver.WindowHandles.Count;
               // Console.WriteLine(countw);
               // Console.WriteLine(isDisplay);
                try
                {
                    
                    isDisplay = SuccessMsg.Displayed;
                    //Console.WriteLine(isDisplay);
                    return "pass";

                }
                catch (Exception)
                {
                    count++;
                    // isDisplay = false;
                   // Console.WriteLine(e) ;
                 //   
                }
               
            }
            return "pass";

        }

    }
}