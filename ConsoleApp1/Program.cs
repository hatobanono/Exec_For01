﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//倒星形三角形
			for(int i = 5; i > 0; i--)
			{
				string row = new string('*', i);
				Console.WriteLine(row);
			}
		}
	}
}
