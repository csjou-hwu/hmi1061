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
		public static void Main()
		{
			Form 表單 = new Form();
			按鈕類別 按鈕物件 = new 按鈕類別();
			按鈕物件.Location = new System.Drawing.Point(100,100);
			表單.Controls.Add(按鈕物件);
			表單.ShowDialog();
		}
	}
	class 按鈕類別 : Button
	{

	}
}
