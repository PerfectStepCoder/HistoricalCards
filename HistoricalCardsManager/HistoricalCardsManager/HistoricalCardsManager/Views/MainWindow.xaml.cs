using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HistoricalCardsManager.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public enum TreeCategories
        {
            FirstCategoty,
            AddRootCategoty,
            EditCategory
        }

        public void GetContextMenuForTreeCategories(ContextMenu contextMenu, TreeCategories treeCategories)
        {
            switch (treeCategories)
            {
                case TreeCategories.FirstCategoty:
                    contextMenu.Items.Add(new MenuItem() { Header = "Добавить категорию" });
                    break;
                case TreeCategories.AddRootCategoty:
                    break;
                case TreeCategories.EditCategory:
                    break;
                default:
                    break;
            }
        }

        private void treeViewCategories_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            TreeView treeViewCategories = sender as TreeView;
            if ( treeViewCategories.SelectedItem == null)
            {
                GetContextMenuForTreeCategories(treeViewCategories.ContextMenu, TreeCategories.FirstCategoty);
                //treeViewCategories.ContextMenu.IsOpen = true;
                //MessageBoxResult result = MessageBox.Show("Нет выделлых узлов");
            }
            
        }


        #region Старый код


        #endregion

        private void TreeCategoryContextMenu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            switch (menuItem.Name)
            {
                case "createCategory":
                    MessageBox.Show(menuItem.Name);
                    break;
                default:
                    break;
            }
        }
        private void treeViewCategories_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
