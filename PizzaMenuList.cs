using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary.Menu
{
    public class PizzaMenuList
    {
        private IList<PizzaMenu> list = new List<PizzaMenu>();

        public IEnumerable<PizzaMenu> Items
        {
            get
            {
                return list;
            }
        }
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        public void AddItem(PizzaMenu item)
        {
            if (item == null)
                throw new ArgumentNullException();
            list.Add(item);
        }


    }
}
