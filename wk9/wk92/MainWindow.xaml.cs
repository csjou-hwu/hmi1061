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

namespace wk92
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer 計時器 = new System.Windows.Threading.DispatcherTimer();
        string[] 字幕 = {"你們這代人，可能還有機會選總統",
                         "當總統需要甚麼。 有超強的...",
                         "很辛苦耶! 那當然，不然...",
                         "當總統也沒麼好什麼好嘛。",
                         "END"
                        };
        int 字幕計數 = 0;

        public MainWindow()
        {
            InitializeComponent();
            計時器.Interval = new TimeSpan(0, 0, 1);
            計時器.Tick += 計時器_Tick;
            tb1.Text = 字幕[字幕計數];
            計時器.Start();
        }

        private void 計時器_Tick(object sender, EventArgs e)
        {
            if (字幕計數 >= 4)
            {
                計時器.Stop();
            }
            else
            {
                tb1.Text = 字幕[++字幕計數];
            }
        }
    }
}
