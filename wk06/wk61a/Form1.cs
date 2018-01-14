using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk61a
{
    public partial class Form1 : Form
    {
        // 陣列
        PictureBox[] 圖片陣列;
        
        public Form1()
        {
            InitializeComponent();
            //加入背景
            this.BackgroundImage = Image.FromFile("grass.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Size = new Size(646, 513);
            DX = new int[5];
            for (int i = 0; i < 5; i++)
            {
                DX[i] = 20 - i * 2;
            }
            // 圖片陣列應用
            圖片陣列 = new PictureBox[5];
            for (int i=0; i<5; i++)
            {
                圖片陣列[i] = new PictureBox();
                圖片陣列[i].Image = Image.FromFile("run.gif");
                圖片陣列[i].Size = new Size(32, 24);
                圖片陣列[i].SizeMode = PictureBoxSizeMode.StretchImage;
                圖片陣列[i].Location = new Point(0, 48 * i);
                this.Controls.Add(圖片陣列[i]);
            }
            計時器 = new Timer();
            計時器.Interval = 100; // 100 ms 0.1 sec
            計時器.Tick += 計時器_Tick;
            計時器.Start();
        }
        Timer 計時器;
        int[] DX;
        private void 計時器_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                int x = 圖片陣列[i].Location.X + DX[i];
                if (x >= 640) x = 0;
                圖片陣列[i].Location = new Point(x, 48 * i);
            }
        }
    }
}
