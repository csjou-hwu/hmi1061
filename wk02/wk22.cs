using System;
// cd
// dir
// mcs wk22.cs
// mono wk22.exe
namespace N1
{
	class C1
	{
		public static void Main()
		{
			Console.WriteLine("Hi 周重石");
			類別2 物件 = new 類別2();
			物件.物件方法();
			類別2.類別方法();
		}
	}
	class 類別2
	{
		public 類別2() //建構元方法
		{
			Console.WriteLine("Hi 建構元方法");
		}
		public void 物件方法()
		{
			Console.WriteLine("Hi 物件方法");
		}
		public static void 類別方法()
		{
			Console.WriteLine("Hi 類別方法");
		}
	}
}
