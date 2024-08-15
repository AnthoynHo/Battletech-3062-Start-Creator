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
using Battletech_3062_Start_Creator.Manager;
using Battletech_3062_Start_Creator.Classes;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.ObjectModel;

namespace Battletech_3062_Start_Creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GearList gearlist = new GearList();
        MechManager mechManager= new MechManager();
        StartsManager startManager = new StartsManager();
        public MainWindow()
        {
            InitializeComponent();
            startManager.PopulateStarts();
            List_of_Starts.ItemsSource = startManager.Starts;
        }

        private void starts_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
