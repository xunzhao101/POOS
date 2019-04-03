using MenuLibrary.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Menu
{
    public class AddPizzzMenuTests
    {
        [Fact]
        public void OnNullArgumentNullErrorOccurs()
        {
            var pizzaMenuList = new PizzaMenuList();
            PizzaMenu item = null;
            var exception = Record.Exception(() => pizzaMenuList.AddItem(item));
            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
        [Fact]
        public void ItAddAPizzaMenuToPizzaMenuList()
        {
            var pizzaMenuList = new PizzaMenuList();
            var pizzaMenu = new PizzaMenu();
            pizzaMenuList.AddItem(pizzaMenu);
            Assert.Equal(1, pizzaMenuList.Count);
        }

        [Fact]
        public void ItAddTwoPizzaMenuToPizzaMenuList()
        {
            var pizzaMenuList = new PizzaMenuList();
            var pizzaMenu1 = new PizzaMenu();
            pizzaMenuList.AddItem(pizzaMenu1);
            var pizzaMenu2 = new PizzaMenu();
            pizzaMenuList.AddItem(pizzaMenu2);
            Assert.Equal(2, pizzaMenuList.Count);
        }

        
        
    }
}
