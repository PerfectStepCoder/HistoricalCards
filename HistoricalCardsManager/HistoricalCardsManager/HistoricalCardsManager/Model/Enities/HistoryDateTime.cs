using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model.Enities
{
    public enum Era
    {
        BC,
        AD
    }

    public enum Calendar
    {
        Unknown,
        Gregorian,
        Julian
    }

    public class HistoryDateTime
    {
        public long Years { get; set; }

        public int Mounth { get; set; }

        public int Day { get; set; }

        public int Hour { get; set; }

        public int Minutes { get; set; }

        public Era Epoch { get; set;}

        public bool IsLeap { get; set; }

        public Calendar Calendar { get; set; }
    }
}
