using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoricalCardsManager.Model.Interfaces;
using HistoricalCardsManager.Model;
using HistoricalCardsManager.Views;

namespace HistoricalCardsManager.Presenters
{
    public class MainPresenter : IModel
    {
        HistoryModel historyModel = null;
        MainWindow mainWindow = null;

        public MainPresenter(HistoryModel historyModel, MainWindow mainWindow)
        {
            this.historyModel = historyModel;
            this.mainWindow = mainWindow;
        }
    }
}
