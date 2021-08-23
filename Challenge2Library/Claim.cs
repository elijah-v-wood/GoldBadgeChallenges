using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Library
{
    public enum ClaimType { Car, Home, Theft, NotValidType}
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
            ClaimID = id; ;
            ClaimType = type;
            Description = desc;
            ClaimAmount = amnt;
            DateOfIncident = incident;
            DateOfClaim = claim;
        }
        public Claim(int id, string type, string desc, decimal amnt, DateTime incident, DateTime claim)
        {
            if (type.Contains("car") || type.Contains("auto"))
            {
                ClaimType = ClaimType.Car;
            }
            else if (type.Contains("home"))
            {
                ClaimType = ClaimType.Home;
            }
            else if (type.Contains("theft"))
            {
                ClaimType = ClaimType.Theft;
            }
            else
            {
                ClaimType = ClaimType.NotValidType;
            }

            ClaimID = id;;
            Description = desc;
            ClaimAmount = amnt;
            DateOfIncident = incident;
            DateOfClaim = claim;
        }
        
    }
}
