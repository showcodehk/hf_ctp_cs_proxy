﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiFeng
{
	class Program
	{
		static void Main(string[] args)
		{
			TestTrade tt = new TestTrade();
			tt.Run();
			Console.WriteLine("Press any key to continue . . . ");
			Console.Read(); 
			tt.ShowInfo();
			Console.Read();

			TestQuote tq = new TestQuote();
			tq.Run();
			Console.WriteLine("Press any key to continue . . . ");
			Console.Read();

			tt.Release();
			tq.Release();
			Console.Read();
		}
	}
}
