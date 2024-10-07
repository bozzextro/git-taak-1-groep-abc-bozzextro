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

namespace Kleurenpsychologie
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

        private void ImgRood_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Red);
        }

        private void ImgGeel_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Yellow);

        }

        private void ImgGroen_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Green);

        }

        private void ImgBlauw_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Blue);

        }

        private void Img_MouseLeave(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.LightGray);

        }

        private void ImgRood_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBoxKleurCode.Text = "#FF0000";
        }

        private void ImgGeel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBoxKleurCode.Text = "#FFFF00";

        }

        private void ImgGroen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBoxKleurCode.Text = "#008000";

        }

        private void ImgBlauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtBoxKleurCode.Text = "#0000FF";

        }
    }
}
