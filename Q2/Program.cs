using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q2計算圖書下個月歸還時間

			DateTime today = DateTime.Today;
			DateTime nextMonth = today.AddMonths(1); //加一個月

			Console.WriteLine($"圖書應於: {nextMonth:MM/dd} 歸還");
		}
	}
}
