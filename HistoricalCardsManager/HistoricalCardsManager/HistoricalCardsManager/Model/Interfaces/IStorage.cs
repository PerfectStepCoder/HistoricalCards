using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalCardsManager.Model.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    interface IStorage
    {
        /// <summary>
        /// Загрузить карточки из хранилища
        /// </summary>
        /// <returns></returns>
        HistoricalCards Load();

        /// <summary>
        /// Сохранить карточки в хранилище
        /// </summary>
        /// <param name="historicalCards"></param>
        void Save(HistoricalCards historicalCards);

    }
}
