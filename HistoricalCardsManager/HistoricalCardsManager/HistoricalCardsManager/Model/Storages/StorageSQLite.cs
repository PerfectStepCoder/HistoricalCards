using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math; // доступность функций из статического класса

namespace HistoricalCardsManager.Model.Storages
{
    /// <summary>
    /// 
    /// </summary>
    class StorageSQLite
    {
        private readonly string pathToFileDataBase;

        private static StorageSQLite instance;

        private StorageSQLite()
        {

        }

        public static StorageSQLite getInstance()
        {
            if (instance == null)
                instance = new StorageSQLite();
            return instance;
        }

        /// <summary>
        /// Освобождаем ресурсы
        /// </summary>
        ~StorageSQLite()
        {

        }
    }
}
