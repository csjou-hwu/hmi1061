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

namespace wk181
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            自我關閉計時器.Interval = new TimeSpan(0, 0, 5); // 5 Sec
            自我關閉計時器.Tick += 自我關閉計時器_Tick;
            this.Closing += MainWindow_Closing;
            自我關閉計時器.Start();
        }
        System.Windows.Threading.DispatcherTimer 自我關閉計時器 = new System.Windows.Threading.DispatcherTimer();
        private void 自我關閉計時器_Tick(object sender, EventArgs e)
        {
            自我關閉計時器.Stop();
            this.Close();
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
        }
    }
}
