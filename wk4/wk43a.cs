using System;
using System.Windows.Forms;
using System.Drawing;
class 類別1
{
	public static void Main()
	{	Application.Run( new 表單()); }
}
class 表單 : Form
{
	public 表單()
	{
	PictureBox P = new PictureBox();
	P.Image = Image.FromFile("stickman.gif");
	this.Size = new Size(400,400);
	P.Size = new Size(400,400);
	this.Controls.Add(P);
//this.BackgroundImage = Image.FromFile("stickman.gif");
	}
}