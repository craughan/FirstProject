using System;

namespace ClassesExercise
{
	class Program
	{
		// This program will determine if a user defined point is
		// contained within a user defined circle, then determine
		// if that circle overlaps another circle with a random
		// position and radius
		static void Main(string[] args)
		{
			//TODO: add properties to classes for user input
			Vector2 point;
			Circle userCircle;
			float pointX, pointY;
			float circlePosX, circlePosY;
			float radius;

			Console.Write("Input x value for your point: ");
			pointX = float.Parse(Console.ReadLine());
			Console.Write("Input y value for your point: ");
			pointY = float.Parse(Console.ReadLine());
			Console.Write("Input x value for you circle's position: ");
			circlePosX = float.Parse(Console.ReadLine());
			Console.Write("Input y value for your circle's position: ");
			circlePosY = float.Parse(Console.ReadLine());
			Console.Write("Input radius for your circle: ");
			radius = float.Parse(Console.ReadLine());
			point = new Vector2(pointX, pointY);
			userCircle = new Circle(circlePosX, circlePosY, radius);

			Random rand = new Random();
			float randCircleX = rand.Next(15);
			float randCircleY = rand.Next(15);
			float randCircleRad = rand.Next(15);
			Circle randCircle = new Circle(randCircleX, randCircleY, randCircleRad);
			Console.WriteLine($"Random Circle Properties:\nPosition: ({randCircleX}, {randCircleY})\nRadius: {randCircleRad}\n");

			string toPrint;
			string does = "does";
			string doesNot = "doesn\'t";
			Console.WriteLine($"Your point {(userCircle.ContainsPoint(point) ? toPrint = does : toPrint = doesNot)} fall within your circle.");
			Console.WriteLine($"Your circle {(userCircle.CheckOverlap(randCircle) ? toPrint = does : toPrint = doesNot)} overlap the randomly generated circle");
		}
	}
}
