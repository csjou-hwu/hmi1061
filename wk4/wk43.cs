// wk43.cs
// mcs wk43.cs -r:System.Windows.Forms.DLL -r:System.Drawing.DLL
// mono wk43.exe
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
	//this.BackgroundImage = Image.FromFile("stickman.gif");
	PictureBox 圖片物件 = new PictureBox();
	圖片物件.Image = Image.FromFile("stickman.gif");
	this.Size = new Size(400,400);
	圖片物件.Size = new Size(400,400);
	this.Controls.Add(圖片物件);
	}
}