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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder sb = new StringBuilder();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event for when any entree button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entree_Click(object sender, RoutedEventArgs e)
        {
            EntreeCustomization window = new EntreeCustomization();
            window.Show();
            
            sb.Append("Entree\n");
            uxRecipt.Text = sb.ToString();
            //MainWindow main = new MainWindow();
            //main.Close();
        }
        
        /// <summary>
        /// Event for when any side button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            //sb.Append(uxVokunButton.Content.ToString());
            sb.Append("Side\n");
            uxRecipt.Text = sb.ToString();
        }

        /// <summary>
        /// Event for when any drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drink_Click(object sender, RoutedEventArgs e)
        {

            DrinkCustomization window = new DrinkCustomization();
            window.Show();
            sb.Append("Drink\n");
            uxRecipt.Text = sb.ToString();
        }

        
    }
}
