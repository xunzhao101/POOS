using MenuLibrary.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Menu
{
    public class CanGetEnumeratorInPizzaMenuListTests
    {
        [Fact]
        public void CanGetEnumeratorInPizzaMenuList()
        {
            var pizzaMenuList = new PizzaMenuList();
            foreach(PizzaMenu item in pizzaMenuList.Items)
            {

            }
        }
    }
}
