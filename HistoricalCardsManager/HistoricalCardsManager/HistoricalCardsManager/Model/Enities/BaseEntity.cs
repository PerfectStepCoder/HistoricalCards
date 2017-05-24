using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        protected int ID { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        protected string Description { get; set; }

        public BaseEntity(int id)
        {
            this.ID = id;
        }
    }
}
