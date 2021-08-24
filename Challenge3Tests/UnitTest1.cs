using Challenge3Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge3Tests
{
    [TestClass]
    public class UnitTest1
    {
            public BadgeDirectory Directory = new BadgeDirectory();
        [TestMethod]
        public void DictionaryPrints()
        {
            Badge b1 = new Badge(12446, "A7 B4");
            Badge b2 = new Badge(12456, "A7 B4 C2");
            Badge b3 = new Badge(13456, "A7 B4 C3");

            Directory.AddToDictionary(b1);
            Directory.AddToDictionary(b2);
            Directory.AddToDictionary(b3);

            Directory.PrintDictionary();

        }
        [TestMethod]
        public void CanChangeBadgeDoorAccess_DictionaryGetsNewValue()
        {
            Badge tester = new Badge(12, "A5");
            Directory.AddToDictionary(tester);

            string expected = "A5";
            string actual = Directory._badgeDictionary[12].DoorAccess;

            Assert.AreEqual(expected, actual);

            tester.DoorAccess = "C4";

            Assert.AreNotEqual(expected, Directory._badgeDictionary[12].DoorAccess);

        }
    }
}
