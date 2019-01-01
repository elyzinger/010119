using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_1010119
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int a, b;
			Console.WriteLine("pick 2 num");
			b = Convert.ToInt32(Console.ReadLine());
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("manu");
			Console.WriteLine("1. plus");
			Console.WriteLine("2. minos");
			Console.WriteLine("3. double");
			Console.WriteLine("4. hezka");
			Console.WriteLine("5. shuresh");
			Console.WriteLine("6. exit");
			Console.Write("what would you like to do    ");
			int button = Convert.ToInt32(Console.ReadLine());
			switch (button)
			{
				case 1: Console.WriteLine(a + b);
					break;
				case 2: Console.WriteLine(a - b);
					break;
				case 3: Console.WriteLine(a * b);
					break;
				case 4:
					Console.WriteLine(Math.Pow(a, b));
					break;
				case 5:
					Console.WriteLine( Math.Pow(a, 1 / b));
					break;
				case 6: Console.WriteLine("bye bye");
					break;

				default:
					break;
			}







		}

	}
}
