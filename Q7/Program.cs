using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q7根據不同時間, 傳回不同問安方式
			DateTime now = DateTime.Now;
			int hour = now.Hour;

			if (0<=hour&&hour<=11)
			{
				Console.WriteLine("早安");
			}
			else if (12<=hour&&hour<=18)
			{
				Console.WriteLine("午安");
			}
			else
			{
				Console.WriteLine("晚安");
			}

		}
	}
}
