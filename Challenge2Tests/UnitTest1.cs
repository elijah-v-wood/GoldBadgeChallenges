using Challenge2Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge2Tests
{
    [TestClass]
    public class UnitTest1
    {

        ClaimRepository claimRepository = new ClaimRepository();

        Claim c1 = new Claim(1, ClaimType.Car, "Accident on 465.", 400.00m, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27));
        Claim c2 = new Claim(2, ClaimType.Home, "House fire in kitchen", 4000.00m, new DateTime(2018, 4, 11), new DateTime(2018, 4, 12));
        Claim c3 = new Claim(3, ClaimType.Theft, "Stolen Pancakes", 4.00m, new DateTime(2018, 4, 27), new DateTime(2018, 6, 1));


        

        [TestMethod]
        public void ColumnPrintForClaims_ShouldPrintinColumns()
        {
            claimRepository.AddtoQueue(c1);
            claimRepository.AddtoQueue(c2);
            claimRepository.AddtoQueue(c3);



            claimRepository.SeeAllClaims();
        }

        [TestMethod]
        public void Peeking()
        {
            claimRepository.AddtoQueue(c1);
            claimRepository.AddtoQueue(c2);
            claimRepository.AddtoQueue(c3);


            claimRepository.PeekQueue();
        }
        [TestMethod]
        public void Dequeue_ShouldReturnTrue()
        {

            claimRepository.AddtoQueue(c1);
            claimRepository.AddtoQueue(c2);
            claimRepository.AddtoQueue(c3);

            bool wasSuccesful=claimRepository.RemoveFromQueue();
            Assert.IsTrue(wasSuccesful);

            claimRepository.PeekQueue();
        }
    }
}
