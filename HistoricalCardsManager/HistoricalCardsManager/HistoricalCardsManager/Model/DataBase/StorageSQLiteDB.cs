using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math; // доступность функций из статического класса

namespace HistoricalCardsManager.Model.DataBase
{
    class StorageSQLiteDB
    {
        private readonly string pathToFileDataBase;

        private static StorageSQLiteDB instance;

        private StorageSQLiteDB()
        {

        }

        public static StorageSQLiteDB getInstance()
        {
            if (instance == null)
                instance = new StorageSQLiteDB();
            return instance;
        }

        /// <summary>
        /// Освобождаем ресурсы
        /// </summary>
        ~StorageSQLiteDB()
        {

        }
    }
}
