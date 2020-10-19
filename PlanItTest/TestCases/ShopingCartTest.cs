using NUnit.Framework;
using PlanItTest.Pages;

namespace PlanItTest
{
    [TestFixture]
    public class ShopingCartTest:BasePage
    {
        public ShopPage shopPage;
       // public NavBar navBar;
        [SetUp]
        public void Setup()
        {
            Setup("https://jupiter.cloud.planittesting.com/");
         
            
          
        }
        ///<summary>
        /// Test case 4:
        /// 1.	From the home page go to shop page
        /// 2.	Click buy button 2 times on “Funny Cow”
        /// 3.	Click buy button 1 time on “Fluffy Bunny”
        /// 4.	Click the cart menu
        /// 5.	Verify the items are in the cart

        ///</summary>
        [Test]
        public void AddingItemtoCartTest()
        {
          
                shopPage = navBar.GetShopPage();
                shopPage.AddItemToTheCart("Funny Cow");
               
                shopPage.ClickFunnyCowToBuy();
                shopPage.ClickBunnyoBuy();
              
                CartPage cartPage = navBar.GetCartPage();
                Assert.IsTrue(cartPage.GetItem("Funny Cow"));
                Assert.IsTrue(cartPage.GetItem("Bunny"));

            
        }
        [TearDown]
        public void TearDown()
        {
           TestCleanUp();
        }
    }
}