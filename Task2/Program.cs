using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			Polynomial p = new Polynomial(new double[3] { 3, -2, 2 }); 
			Polynomial z = new Polynomial(new double[4] { 2, 2, 0, 3 });
			var a = p + z;
			Console.WriteLine(a);
		}
	}
}
