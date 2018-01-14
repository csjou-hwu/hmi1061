using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk61
{
    public partial class Form1 : Form
    {
        PictureBox[] 圖片陣列;
        public Form1()
        {
            InitializeComponent();
            //--
            this.BackgroundImage = Image.FromFile("grass.jpg");
            this.Size = new Size(646, 513);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            圖片陣列 = new PictureBox[5];
            for (int i=0; i<5; i++)
            {
                圖片陣列[i] = new PictureBox();
                圖片陣列[i].Image = Image.FromFile("run.gif");
                圖片陣列[i].Size = new Size(32, 24);
                圖片陣列[i].SizeMode = PictureBoxSizeMode.StretchImage;
                圖片陣列[i].Location = new Point(0, i * 48);
                this.Controls.Add(圖片陣列[i]);
            }
        }
    }
}
