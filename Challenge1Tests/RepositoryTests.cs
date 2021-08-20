using Challenge1Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge1Tests
{
    [TestClass]
    public class RepositoryTests
    {
        private MenuRepository _menu;
        private MenuItem _item;

        [TestInitialize]
        public void Arrange()
        {
            _menu = new MenuRepository();
            _item = new MenuItem(1, "Chicken Parmesan", "Breaded Chicken covered in Parmesan and an hearthy tomato sauce.", "chicken breast, bread crumbs, our special tomato sauce, parmesan, mozarella, and select herbs and spices.", 23.20m);
        }
        [TestMethod]
        public void AddMenuItem_ShouldReturnTrue()
        {

            bool addSuccessful = _menu.AddItemtoMenu(_item);
            Assert.IsTrue(addSuccessful);
            
        }
        [TestMethod]
        public void GetMenu_ShouldReturnMenu()
        {
            _menu.AddItemtoMenu(_item);

            List<MenuItem> printMenu = _menu.GetMenuItems();

            bool printHasMenu = printMenu.Contains(_item);

            Assert.IsTrue(printHasMenu);
        }
        [TestMethod]
        public void RemoveItem_ShouldNotReturnItem()
        {
            _menu.AddItemtoMenu(_item);

            bool removalSuccesful = _menu.DeleteMenuItem(_item);

            Assert.IsTrue(removalSuccesful);
        }
    }
}
