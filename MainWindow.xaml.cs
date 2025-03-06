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
        

        public MainWindow()
        {
            InitializeComponent();
            ItemCollectionManager itemCollectionManager = new ItemCollectionManager();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            StartCreator startWindow = new StartCreator();
            startWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Collections collectionWindow = new Collections();
            collectionWindow.Show();
        }
    }
}