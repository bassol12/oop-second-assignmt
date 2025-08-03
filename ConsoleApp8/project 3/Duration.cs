using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.project_3
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public  Duration(int hours, int minutes, int seconds) 
        {
         this.Hours = hours;
          this.Minutes = minutes;
          this.Seconds = seconds;

        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            int remaining = totalSeconds % 3600;
            Minutes = remaining / 60;
            Seconds = remaining % 60;
        }
        public override string ToString() 
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Minutes :{Minutes}, Seconds :{Seconds}";

        }

        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return this.Hours == other.Hours &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.TotalSeconds() + d2.TotalSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds = d1.TotalSeconds() - d2.TotalSeconds();
            if (totalSeconds < 0) totalSeconds = 0;
            return new Duration(totalSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            int total = d.TotalSeconds() - 60;
            if (total < 0) total = 0;
            return new Duration(total);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }



    }
}
