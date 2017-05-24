using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    public class HistoricalCard : BaseEntity
    {
        public List<Category> Categories { get; set; }

        // TODO: именованные параметры в методах

        // Nullable type int t = nullType ?? 0;

        // ref and out

        // используй TryParse

        
        public HistoricalCard(int id, string description = ""): base(id)
        {
            this.Description = description;
        }
    }
}
