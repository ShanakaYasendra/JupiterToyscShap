using NUnit.Framework;
using PlanItTest.Pages;

namespace PlanItTest
{
    [TestFixture]
    public class ShopingCartTest:BasePage
    {
        public ShopPage shopPage;

        [SetUp]
        public void Setup()
        {
            navBar.GetShopPage();
            shopPage = new ShopPage(driver);
        }
        ///<summary>
        /// Test case 4:
        /// 1.	From the home page go to shop page
        /// 2.	Click buy button 2 times on “Funny Cow”
        /// 3.	Click buy button 1 time on “Fluffy Bunny”
        /// 4.	Click the cart menu
        /// 5.	Verify the items are in the cart

        ///</summary>
        [Test,Order(5)]
        public void AddingItemtoCartTest()
        {
                //navBar.GetShopPage();
               // ShopPage shopPage = new ShopPage(driver);
                shopPage = new ShopPage(driver);
                shopPage.ClickFunnyCowToBuy();
                shopPage.ClickFunnyCowToBuy();
                shopPage.ClickBunnyoBuy();
                navBar.GetCartPage();
                CartPage cartPage = new CartPage(driver);
                Assert.IsTrue(cartPage.GetItem("Funny Cow"));
                Assert.IsTrue(cartPage.GetItem("Bunny"));

            
        }
        [Test, Order(6)]
        public void TearDown()
        {
            TestCleanUp();
        }
    }
}