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

        [Test]
        public void Test1()
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
        [TearDown]
        public void TearDown()
        {
        //    TestCleanUp();
        }
    }
}