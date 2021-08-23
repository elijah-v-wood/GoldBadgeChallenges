using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Library
{
    public class ClaimRepository
    {
        Queue<Claim> _claimQueue = new Queue<Claim>();
        Claim Claim = new Claim();


        public bool AddtoQueue(Claim claim)
        {
            int startingCount = _claimQueue.Count;
            _claimQueue.Enqueue(claim);
            bool wasAdded = _claimQueue.Count > startingCount;
            return wasAdded;
        }
        public bool RemoveFromQueue()
        {
            int startingCount = _claimQueue.Count;
            _claimQueue.Dequeue();

            bool wasRemoved = _claimQueue.Count < startingCount;
            return wasRemoved;
        }
        public void SeeAllClaims()
        {
            //Kind of ugly looking, but I'll refactor it after the rest of the code is built out

            Console.WriteLine($"{"Claim ID",-10} {"Type",-10} {"Description",-10} " +
                $"{"Amount",10} {"Incident Date",10} {"Claim Date",10} {"Valid Claim",10}");
            foreach(Claim item in _claimQueue)
            {
                Console.WriteLine($"{item.ClaimID,-10} {item.ClaimType,-10} {item.Description,-10} " +
                $"{item.ClaimAmount,10} {item.DateOfIncident,10} {item.DateOfClaim,10} {item.IsValid,10}");
            }
        }
        public void PeekQueue()
        {
            Claim query = _claimQueue.Peek();

            Console.WriteLine($"Claim ID: {query.ClaimID}");
            Console.WriteLine($"Claim Type: {query.ClaimType}");
            Console.WriteLine($"Description: {query.Description}");
            Console.WriteLine($"Amount: {query.ClaimAmount}");
            Console.WriteLine($"Incident Date: {query.DateOfIncident.ToString("d")}");
            Console.WriteLine($"Claim Date: {query.DateOfClaim.ToString("d")}");
            Console.WriteLine($"Valid Claim: {query.IsValid}");
        }

    }
}
