using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop_5
{
    internal class Duration
    {
        #region question 01
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        #endregion
        #region question 02
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {

            int hash = 17;
            hash = hash * 23 + Hours.GetHashCode();
            hash = hash * 23 + Minutes.GetHashCode();
            hash = hash * 23 + Seconds.GetHashCode();
            return hash;

        }
        #endregion
        #region question 03

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

     

        #endregion
    }
}
