using NUnit.Framework;
using TestPlanIt.Pages;

namespace PlanItTest
{
    public class ShopingCartTest:BasePage
    {
        [SetUp]
        public void Setup()
        {
            navBar.GetShopPage();
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
            
                
                ShopPage shopPage = new ShopPage(driver);
                shopPage = new ShopPage(driver);
                shopPage.ClickFunnyCowToBuy();
                shopPage.ClickFunnyCowToBuy();
                shopPage.ClickBunnyoBuy();
                navBar.GetCartPage();
                CartPage cartPage = new CartPage(driver);
                Assert.IsTrue(cartPage.GetItem("Funny Cow"));
                Assert.IsTrue(cartPage.GetItem("Bunny"));

            
        }
       
    }
}