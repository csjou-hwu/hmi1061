using System;
// cd
// dir
// mcs wk24.cs -r:System.Windows.Forms.DLL
// mono wk24.exe
using System.Windows.Forms;
namespace N1
{
	class C1
	{
		static 按鈕類別 按鈕物件;
		public static void Main()
		{
			Form 表單 = new Form();
			按鈕物件 = new 按鈕類別();
			按鈕物件.Location = new System.Drawing.Point(100,0);
			表單.Controls.Add(按鈕物件);
			Timer 計時器 = new Timer();
			計時器.Interval = 1000;
			計時器.Tick += new EventHandler(時間到);
			計時器.Start();
			表單.ShowDialog();
		}
		static int y =0;
		private static void 時間到(Object O, EventArgs e)
		{
		     y += 10;
		     按鈕物件.Location = new System.Drawing.Point(100,y);
		}
	}
	class 按鈕類別 : Button
	{

	}
}
