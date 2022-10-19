using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q4取得本月最後一天

			DateTime today = DateTime.Today;
			int year = today.Year;
			int month = today.Month;

			//下個月1號減1天即本月最後一天
			DateTime thisMonthsLastDay = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

			Console.WriteLine($"本月最後一天為 {thisMonthsLastDay:MM/dd}");
			


		}
	}
}
