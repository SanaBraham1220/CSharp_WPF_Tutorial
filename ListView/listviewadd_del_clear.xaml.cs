using Microsoft.VisualBasic;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LvEntries.Items.Add('a');
            LvEntries.Items.Add("ab");
            LvEntries.Items.Add("abc");
            LvEntries.Items.Add("abcd");
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            LvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            /* for SelectionMode="Single"in LvEntries
            //To select by Index
            //int index = LvEntries.SelectedIndex;
            //LvEntries.Items.RemoveAt(index);
            object value = LvEntries.SelectedItem;
            //To select by Value
            var result = MessageBox.Show($"Are you Sure do you want to delete {value}","Sure?", MessageBoxButton.YesNo);
            if (result==MessageBoxResult.Yes)
            LvEntries.Items.Remove(value);*/

            /* for SelectionMode="MultipleSelection" in LvEntries */
            var items = LvEntries.SelectedItems;
            var result = MessageBox.Show($"Are you Sure do you want to delete {items.Count} items ", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                {
                    LvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            LvEntries.Items.Clear();
        }
    }
}