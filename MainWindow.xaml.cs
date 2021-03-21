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

namespace japanese_dict
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wordBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a word!");
            }

            string x = wordBox.SelectedItem.ToString(); //Converts items in list to string
            engWord.Content = jpndict.main_Dict(x); //Changes content in label to show JPN hiragana and romaji
        }
    }
}
