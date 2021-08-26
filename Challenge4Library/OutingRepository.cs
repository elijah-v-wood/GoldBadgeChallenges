using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4Library
{
    public class OutingRepository
    {
        Outing _outing = new Outing();
        List<Outing> _outingRepo = new List<Outing>();

        public List<Outing> GetOut()
        {
            return _outingRepo;
        }

        public bool AddOuting(Outing outing)
        {
            int startingCount = _outingRepo.Count;
            _outingRepo.Add(outing);
            bool wasAdded = _outingRepo.Count > startingCount;
            return wasAdded;
        }

        public List<Outing> AllOutingsByType(EventType Event)
        {
            List<Outing> OutingByType = new List<Outing>();
            foreach(Outing outing in _outingRepo)
            {
                if(outing.Event == Event)
                {
                    OutingByType.Add(outing);
                }
            }
            return OutingByType;
        }
        public decimal GrandTotal()
        {
            decimal grandsum = 0;
            foreach(Outing outing in _outingRepo)
            {
                grandsum += outing.TotalCost;
            }
            return grandsum;
        }
        public decimal GrandTotalByType(EventType Event)
        {
            List<Outing> OutingByType = new List<Outing>();
            foreach (Outing outing in _outingRepo)
            {
                if (outing.Event == Event)
                {
                    OutingByType.Add(outing);
                }
            }
            decimal grandsum = 0;
            foreach(Outing outing in OutingByType)
            {
                grandsum += outing.TotalCost;
            }
            return grandsum;
        }

    }
}
