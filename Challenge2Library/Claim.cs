using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Library
{
    public enum ClaimType { Car, Home, Theft}
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid 
        { get
            {
                TimeSpan ClaimDifference = DateOfClaim - DateOfIncident;
                if (ClaimDifference.Days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }

        public Claim() { }
        public Claim(int id, ClaimType type, string desc, decimal amnt, DateTime incident, DateTime claim)
        {
            ClaimID = id;
            ClaimType = type;
            Description = desc;
            ClaimAmount = amnt;
            DateOfIncident = incident;
            DateOfClaim = claim;
        }
        
    }
}
