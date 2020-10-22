using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
namespace PlanItTest.Util
{
    public class ElementHelper
    {
        private IWebDriver driver;

        public ElementHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetElementByID( string element)
        {
            return driver.FindElement(By.Id(element));

        }
        public IWebElement GetElementByClassName(string element)
        {
            return driver.FindElement(By.ClassName(element));

        }
        public IWebElement GetElementByCss(string element)
        {
            return driver.FindElement(By.CssSelector(element));

        }
        public IWebElement GetElementByXPath(string element)
        {
            return driver.FindElement(By.XPath(element));

        }
        public IWebElement GetElementByLinkText( string element)
        {
            return driver.FindElement(By.LinkText(element));

        }
        public IWebElement GetElementByName(string element)
        {
            return driver.FindElement(By.Name(element));

        }
        public IWebElement GetElementByTag(string element)
        {
            return driver.FindElement(By.TagName(element));

        }
        public IWebElement GetElementByPartialLinkText( string element)
        {
            return driver.FindElement(By.PartialLinkText(element));

        }
    }
}
