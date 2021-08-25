using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4Library
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert }
    public class Outing
    {
        public EventType Event { get; set; }
        public decimal EventCost { get; set; }
        public int Attendees { get; set; }
        public decimal CostPerHead { get; set; }

        public decimal CostOfAttendees
        {
            get
            {
                return Attendees * CostPerHead;
            }
        }
        public DateTime DateOfEvent { get; set; }
        public decimal TotalCost
        {
            get
            {
                return EventCost + CostOfAttendees;
            }
        }



    }
}
