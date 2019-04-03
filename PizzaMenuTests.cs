using MenuLibrary.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Menu
{
    
    public class PizzaMenuTests
    {
        [Fact]
        public void ItExists()
        {
            var pizzaMenu = new PizzaMenu();
        }

        [Fact]
        public void IdentifyPizzaMenu()
        {

            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Name = "HawaiiPizza";
            Assert.Equal("HawaiiPizza", pizzaMenu.Name);
        }
    }
}
