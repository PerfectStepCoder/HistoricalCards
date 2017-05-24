using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    public class Period
    {
        public int Lenght { get; private set; } = 0; // начальное значение 0

        public Period() : base () // вызов базового конструктора
        {
            
        }

        //public Period() : this(6) // переключение конструктора на другой в этом классе
        //{

        //}
    }
}
