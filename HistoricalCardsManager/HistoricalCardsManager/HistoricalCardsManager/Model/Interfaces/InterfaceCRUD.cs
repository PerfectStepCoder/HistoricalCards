using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model.Interfaces
{
    interface InterfaceCRUD
    {
        void Add(HistoricalCard historicalCard);

        void Add(HistoricalCards historicalCards);


    }
}
