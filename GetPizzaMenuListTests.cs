using POOSWebApp.Controllers.DisplayMenu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Menu
{
    public class GetPizzaMenuListTests
    {
        [Fact]
        public void GetPizzaMenuList()
        {
            var controller = new PizzaMenuController();
            var menuList = controller.GetPizzaMenuList();
            Assert.NotNull(menuList);
        }
    }
}
