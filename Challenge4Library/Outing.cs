using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4Library
{
    public enum EventType { Golf,Bowling, AmusementPark, Concert}
    public class Outing
    {
        public EventType Event { get; set; }

    }
}
