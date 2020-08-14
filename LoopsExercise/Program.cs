using System;

namespace LoopsExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int score = 0;

			// print number of times loops runs, 10X
			int i = 0;
			while (i < 10)
			{
				i++;
				Console.WriteLine("This while loop has run " + i + " time(s).");
			}

			// same thing, but for loop
			for (int j = 1; j <= 10; j++)
			{
				Console.WriteLine($"This for loop has run {j} time(s).");
				
				// when score reaches 100, break loop
				if (score < 100)
				{
					score += 20;
				}
				else
				{
					break;
				}
			}

			Console.ReadLine();
		}
	}
}
