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

namespace Aymen_Chakir
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtb1.Text = slid1.Value.ToString("0");
        }

        private void slid2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtb2.Text = slid2.Value.ToString("0");
        }

        private void slid3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtb3.Text = slid3.Value.ToString("0");
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            txtb11.Text = txtb1.Text;
            txtb22.Text = txtb2.Text;
            txtb33.Text = txtb3.Text;
            Listb.Items.Add(txtb2.Text);
            Listb.Items.Add(txtb3.Text);
            Listb.Items.Add(txtb1.Text);
            txtb6.Text = Listb.Items[0].ToString();
            txtb5.Text = Listb.Items[1].ToString();
            txtb4.Text = Listb.Items[2].ToString();
        }
        
    }
}