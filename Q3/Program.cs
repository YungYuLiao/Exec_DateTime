using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q3取得本月一日

			DateTime today= DateTime.Today; //本日
			Console.WriteLine($"本月一日為: {today:MM 月} 01日");
			
		}
	}
}
