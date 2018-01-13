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

namespace wk71
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //< !--< Grid.Background >
            //< ImageBrush ImageSource = "C:\Users\G521\source\repos\wk7\wk71\bin\Debug\run.gif" />
            //</ Grid.Background > -->
            //ImageBrush img = new ImageBrush();
            //img.ImageSource = new BitmapImage(new Uri(@"C:\Users\G521\source\repos\wk7\wk71\bin\Debug\run.gif"));
            //G1.Background = img;
            //M1.Play();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            M1.Position = new TimeSpan(0, 0, 1);
            M1.Play();
        }
    }
}
