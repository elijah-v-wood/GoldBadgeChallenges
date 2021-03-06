using Challenge4Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge4Tests
{
    [TestClass]
    public class UnitTest1
    {
        OutingRepository outingRepository = new OutingRepository();
        Outing out1 = new Outing(EventType.Golf, 2000m, 15, 50m, new DateTime(2018,04,23));
        Outing out2 = new Outing(EventType.Golf, 1800m, 25, 50m, new DateTime(2019,04,23));
        Outing out3 = new Outing(EventType.AmusementPark, 3000m, 60, 110m, new DateTime(2021,05,22));
        Outing out4 = new Outing(EventType.Bowling, 500m, 30, 20m, new DateTime(2020,08,13));


        [TestMethod]
        public void TotalCost_ShouldReturnAsEqual()
        {
            outingRepository.AddOuting(out1);
            outingRepository.AddOuting(out2);
            outingRepository.AddOuting(out3);
            outingRepository.AddOuting(out4);

            decimal actual = outingRepository.GrandTotal();
            decimal expected = 16500m;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CostByType_ShouldReturnGolfCost()
        {
            outingRepository.AddOuting(out1);
            outingRepository.AddOuting(out2);
            outingRepository.AddOuting(out3);
            outingRepository.AddOuting(out4);

            decimal actual = outingRepository.GrandTotalByType(EventType.Golf);

            decimal expected = 5800m;

            Assert.AreEqual(expected, actual);

        }
    }
}
