﻿using System;
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
this.BackgroundImage = Image.FromFile("stickman.gif");
	}
}