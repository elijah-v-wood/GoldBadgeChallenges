using Challenge1Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge1Tests
{
    [TestClass]
    public class MenuItemTest
    {
            MenuItem menuItem1 = new MenuItem(1, "Chicken Parmesan", "Breaded Chicken covered in Parmesan and an hearthy tomato sauce.", "chicken breast, bread crumbs, our special tomato sauce, parmesan, mozarella, and select herbs and spices.", 23.20m);

        [TestMethod]
        public void SetPropertiesNumber_ShouldgetCorrectNumber()
        {

            int expected = menuItem1.MealNumber;
            int actual = 1;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MyTestMethod()
        {

        }
    }
}
