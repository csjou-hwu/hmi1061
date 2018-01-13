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

namespace wk111
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double R = 10;
        double ang = 90;

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                ang += 5;
            }
            else
            {
                ang -= 5;

            }
            double x = R * Math.Cos(ang / 180 * Math.PI);
            double z = R * Math.Sin(ang / 180 * Math.PI);

            CAM.Position = new System.Windows.Media.Media3D.Point3D(
                x,
                CAM.Position.Y,
                z
                );
            CAM.LookDirection = new System.Windows.Media.Media3D.Vector3D(-x, -CAM.Position.Y, -z);
        }
    }
}
