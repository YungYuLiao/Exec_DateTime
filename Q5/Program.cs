using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q5列出指定年份的每一個星期日

			//指定年份的元旦
			Console.Write("請指定年份:");
			string input = Console.ReadLine();
			int year = Convert.ToInt32(input);
			DateTime start = new DateTime(year, 1, 1);
			DateTime end = new DateTime(year, 12, 31);

			//找出第一個星期日, 再用迴圈+7列出每一個星期日
			DayOfWeek weekday = start.DayOfWeek;
			int weekdayInteger = (int)weekday;

			if (weekdayInteger > 0)
			{

				for (DateTime dt = start; dt < end; dt=dt.AddDays(7 - weekdayInteger))
				{
					Console.WriteLine($"{dt:MM/dd}");
				}
			}
			else
			{
				for (DateTime dt = start; dt < end; dt=dt.AddDays(7))
				{
					Console.WriteLine($"{dt:MM/dd}");
				}
			}
		}
	}
}
