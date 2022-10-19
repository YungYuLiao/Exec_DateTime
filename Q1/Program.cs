using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1計算三天後 DVD 應歸還時間

			DateTime today = DateTime.Today;
			DateTime threeDaysAfter = today.AddDays(3); //加三天

			Console.WriteLine($"DVD應於: {threeDaysAfter:yyyy/MM/dd} 歸還");

		}
	}
}
