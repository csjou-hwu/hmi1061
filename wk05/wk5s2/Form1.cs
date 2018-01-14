using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk5s2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(506, 415);
            for (int i = 0; i < 5; i++)
            {
                火柴人 火柴人物件 = new 火柴人();
                火柴人物件.Location = new Point(0, 82 * i);
                this.Controls.Add(火柴人物件);
            }
        }
    }
    class 火柴人 : PictureBox
    {
        public 火柴人()
        {
            this.Size = new Size(506/5, 412/5);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image =
                Image.FromFile(@"C:\Users\G521\source\repos\wk5\run.gif");
        }
    }
}
