using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HistoricalCardsManager.Presenters;
using HistoricalCardsManager.Model;
using HistoricalCardsManager.Views;

namespace HistoricalCardsManager
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            HistoryModel model = new HistoryModel();
            MainWindow mainWindow = new MainWindow();
            MainPresenter mainPresenter = new MainPresenter(model, mainWindow);
            mainWindow.Show();
        }
       
    }
}
