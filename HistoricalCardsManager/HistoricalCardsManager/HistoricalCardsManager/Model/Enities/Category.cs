using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    /// <summary>
    /// Категория исторических карточек
    /// </summary>
    public class Category: BaseEntity
    {
        protected int? IdParent { get; set; }

        public Category(int id):base(id)
        {

        }
    }
}
