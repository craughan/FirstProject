using System;

namespace VariablesOperatorsExpressions
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 15;
			int b = 2;
			double c = 2.5;
			bool trust = false;
			Console.WriteLine((a + c) - (b * c) + a);	// prints 27.5
			Console.WriteLine((!(a < b) || trust) && (!((c >= b) || trust)));	// prints False
			Console.ReadLine();
		}
	}
}
