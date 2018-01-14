using System;
using System.Windows.Forms;
using System.Drawing;

public class Class1
{
	public static void Main()
	{
        Application.Run(new 表單());
	}
}
class 表單 : Form
{
    public 表單()
    {
        this.BackgroundImage = Image.FromFile("stickman.gif");
    }
}
