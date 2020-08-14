using System;

namespace IfStatementsExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			bool playerAlive = true;
			int invulnerabilityTimer = 3;
			invulnerabilityTimer -= 1;

			// let the player know if they are dead or alive
			if (playerAlive)
			{
				Console.WriteLine("You are still alive.");
			}
			else
			{
				Console.WriteLine("You are dead.");
			}

			// let the player know when they are vulnerable when the timer runs out
			if (invulnerabilityTimer > 0)
			{
				if (playerAlive)
				{
					invulnerabilityTimer--;
				}
				Console.WriteLine("You are invulnerable.");
			}
			else if (invulnerabilityTimer == 0)
			{
				Console.WriteLine("You are vulnerable.");
			}
			else if (invulnerabilityTimer < 0)
			{
				invulnerabilityTimer = 0;
			}

		}
	}
}
