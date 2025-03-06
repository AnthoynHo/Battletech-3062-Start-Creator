using Battletech_3062_Start_Creator.Classes;
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

namespace Battletech_3062_Start_Creator
{
    /// <summary>
    /// Interaction logic for StartCreator.xaml
    /// </summary>
    public partial class StartCreator : Window
    {

        StartsManager startManager = new StartsManager();
        ItemCollectionManager itemCollectionManager = new ItemCollectionManager();

        public StartCreator()
        {
            InitializeComponent();
            startManager.PopulateStarts();
            this.DataContext = startManager;
            List_of_Starts.ItemsSource = startManager.Starts;
        }

        private void List_of_Starts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStart = (Start)List_of_Starts.SelectedItem;
            int selectedIndex = List_of_Starts.SelectedIndex;
            if (selectedStart != null)
            {
                Console.Write("Selected Item Text: " + selectedStart.ToString() + "\n" + "Index: " + selectedStart.ToString());
                ID.Text = selectedStart.ID.ToString();
                Name.Text = selectedStart.Name.ToString();
                StartSystem.Text = selectedStart.System.ToString();
                Score.Text = selectedStart.ScoreModifier.ToString();
                List_of_Collections.ItemsSource = selectedStart.MechLists;
            }
        }
    }
}
