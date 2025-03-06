using Battletech_3062_Start_Creator.Manager;
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
using System.Windows.Shapes;
using Battletech_3062_Start_Creator.Classes;

namespace Battletech_3062_Start_Creator
{
    /// <summary>
    /// Interaction logic for Collections.xaml
    /// </summary>
    public partial class Collections : Window
    {
        ItemCollectionManager collectionsManager = new ItemCollectionManager();
        public Collections()
        {
            InitializeComponent();
            collectionsManager.PopulateItemCollections();
            this.DataContext = collectionsManager;
            List_of_Collections.ItemsSource = collectionsManager.Collections;

        }

        private void List_of_Collections_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCollection = (Collection)List_of_Collections.SelectedItem;
            int selectedIndex = List_of_Collections.SelectedIndex;
            List_of_Mechs.ItemsSource = selectedCollection.Mechs;
            if (selectedIndex < 0)
            {
                Console.WriteLine("Selected Index: " + selectedIndex);
                Console.WriteLine("Selected Collection: " + selectedCollection);
            }
        }
    }
}
