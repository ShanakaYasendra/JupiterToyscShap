﻿using TestPlanIt.Pages;

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;

namespace TestPlanIt.Pages
{
    public class ContactPage : BasePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);

        }


        //find Forename input field
        [FindsBy(How = How.Id, Using = "forename")]
        [CacheLookup]
        public IWebElement Forename
        {
            get; set;
        }

        //Find Surname Input fiels
        [FindsBy(How = How.Id, Using = "surname")]

        public IWebElement Surname
        {
            get; set;
        }

        //Find Email Input fiels
        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        public IWebElement Email
        {
            get; set;
        }

        //Find Telephone Input fiels
        [FindsBy(How = How.Id, Using = "telephone")]
        [CacheLookup]
        public IWebElement Telephone
        {
            get; set;
        }
        //Find Message Input fiels
        [FindsBy(How = How.Id, Using = "message")]
        [CacheLookup]
        public IWebElement Message
        {
            get; set;
        }

        //Find Submit button
        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'btn-contact btn btn-primary')]")]
        [CacheLookup]
        public IWebElement Submitbtn
        {
            get; set;
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'alert alert-success')]")]
        public IWebElement SuccessMsg
        {
            get; set;
        }

        [FindsBy(How = How.CssSelector, Using = ".modal - body")]
        public IWebElement Modal
        {
            get; set;
        }

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
            Thread.Sleep(1000);
            //  _ = wait;
            Submitbtn.Click();
        }

        public string GetErrorMessage(string fieldName)
        {
            string element = fieldName + "-err";
            return GetTextVale(element);
        }

        public bool IsErrorPresent(string fieldName)
        {
            string element = fieldName + "-err";
            return IsElementDisplay(element);
        }

        public string waitForModeltoClose()
        {
            _ = wait;

            bool isDisplay = true;
            while (isDisplay.Equals(true))
            {
                // count = driver.WindowHandles.Count;
                try
                {
                    isDisplay = driver.FindElement(By.CssSelector(".modal-body")).Enabled;
                    Console.WriteLine(isDisplay);

                }
                catch (Exception e)
                {
                    isDisplay = false;
                }
            }
            return "pass";
        }

    }
}