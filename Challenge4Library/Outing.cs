using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4Library
{
    public enum EventType { Golf, Bowling, AmusementPark, Concert, NoType }
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
        public Outing() { }
        public Outing(EventType type, decimal eventCost, int attendees, decimal perHead, DateTime date)
        {
            Event = type;
            EventCost = eventCost;
            Attendees = attendees;
            CostPerHead = perHead;
        }
        //I wanted to try a constructor that does all the parsing in the construction
        public Outing(string type, string eventCost,string attendees, string perHead, string date)
        {
            decimal cost = decimal.Parse(eventCost);
            int people = int.Parse(attendees);
            decimal headCost = decimal.Parse(perHead);
            DateTime dateTime = DateTime.Parse(date);
            EventType eventType;
            type.ToLower();
            switch (type)
            {
                case string a when a.Contains("golf"):
                    eventType = EventType.Golf;
                    break;
                case string a when a.Contains("bowling"):
                    eventType = EventType.Bowling;
                    break;
                case string a when a.Contains("amusement"):
                    eventType = EventType.AmusementPark;
                    break;
                case string a when a.Contains("concert"):
                    eventType = EventType.Concert;
                    break;
                default:
                    Console.WriteLine("Failed to set event type.");
                    eventType = EventType.NoType;
                    break;
            }
            Event = eventType;
            EventCost = cost;
            Attendees = people;
            CostPerHead = headCost;
            DateOfEvent = dateTime;

        }



    }
}
