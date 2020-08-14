using System;

namespace FunctionsExercise
{
	class Game
	{
		
		public int score = 0;

		public void Start()
		{
			Console.WriteLine("Score: " + score);
			PrintScore(50);
			PrintScore(100);
			PrintScore(75);
		}

		public void PrintScore(int add)
		{
			Console.WriteLine("Score: " + AddToScore(add));
		}

		public int AddToScore(int add)
		{
			score += add;
			return score;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();
			game.score = 100;
			game.Start();
		}
	}
}
