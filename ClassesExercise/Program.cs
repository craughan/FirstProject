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
			string userInput;

			do
			{
				Console.WriteLine("Enter \'1\' for the Circle Program. Enter \'2\' for the Employee Program. Enter \'0\' to quit.");
				userInput = Console.ReadLine();
				switch (userInput)
				{
					case "1":
						CircleProgram();
						break;
					case "2":
						EmployeeProgram();
						break;
					default:
						break;
				}
			} while (userInput != "0");
				
		}

		public static void CircleProgram()
		{
			Vector2 point = new Vector2();
			Circle userCircle = new Circle();
			Vector2 circlePos = new Vector2();
			userCircle.position = circlePos;
			float radius;

			Console.Write("Input x value for your point: ");
			point.x = float.Parse(Console.ReadLine());
			Console.Write("Input y value for your point: ");
			point.y = float.Parse(Console.ReadLine());
			Console.Write("Input x value for you circle's position: ");
			circlePos.x = float.Parse(Console.ReadLine());
			Console.Write("Input y value for your circle's position: ");
			circlePos.y = float.Parse(Console.ReadLine());
			Console.Write("Input radius for your circle: ");
			radius = float.Parse(Console.ReadLine());


			Random rand = new Random();
			Circle randCircle = new Circle();
			Vector2 randCirclePos = new Vector2();			//TODO: figure out how to initialize this vector within the circle class
			randCircle.position = randCirclePos;
			randCircle.position.x = rand.Next(15);
			randCircle.position.y = rand.Next(15);
			randCircle.radius = rand.Next(10);
			Console.WriteLine($"Random Circle Properties:\nPosition: ({randCircle.position.x}, {randCircle.position.y})\nRadius: {randCircle.radius}\n");

			string doesOrNot;
			string does = "does";
			string doesNot = "doesn\'t";
			Console.WriteLine($"Your point {(userCircle.ContainsPoint(point) ? doesOrNot = does : doesOrNot = doesNot)} fall within your circle.");
			Console.WriteLine($"Your circle {(userCircle.CheckOverlap(randCircle) ? doesOrNot = does : doesOrNot = doesNot)} overlap the randomly generated circle");
		}

		public static void EmployeeProgram()
		{
			char userSelect = ' ';
			do
			{
				Employee maro = new Employee();
				maro.firstName = "Maro";
				maro.lastName = "Maro";
				maro.yearsOfExperience = 5;

				Employee lugi = new Employee();
				lugi.firstName = "Lugi";
				lugi.lastName = "Maro";             //no, I did not typo. All hail Lugi and Maro
				lugi.yearsOfExperience = 2;

				Team team = new Team();
				team.employees = new Employee[] { maro, lugi };

				for (int i = 0; i < team.employees.Length; i++)
				{
					team.employees[i].PrintEmployee();
				}
				team.PrintAverageExperience();

				Employee pech = new Employee();
				pech.firstName = "Princess";
				pech.lastName = "Pech";
				pech.yearsOfExperience = 10;
				team.AddEmployee(pech);
				pech.PrintEmployee();
				team.PrintAverageExperience();
			} while (userSelect == 'y' || userSelect == 'Y');
		}

		
	}
}
