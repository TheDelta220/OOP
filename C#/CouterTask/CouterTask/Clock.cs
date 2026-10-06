using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CouterTask
{
    internal class Clock
    {
        //fields
        private Counter seconds;
        private Counter minutes;
        private Counter hours;

        public Clock(Counter counter)
        {
            //constructor
            seconds = new Counter("seconds");
            minutes = new Counter("minutes");
            hours = new Counter("hours");
        }
        public void Update()
        {
           seconds.Increment();
            if(seconds.Ticks == 60)
            {
                seconds.Reset();
                minutes.Increment();
            }
            if (minutes.Ticks == 60)
            {
                minutes.Reset();
                hours.Increment();
            }
            if (hours.Ticks == 24)
            {
                hours.Reset();
                minutes.Reset();
                seconds.Reset();
            }
        }
        public string Display()
        {
            return $"{hours.Ticks:00}:{minutes.Ticks:00}:{seconds.Ticks:00}";
        }
    }
}
