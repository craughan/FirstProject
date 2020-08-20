using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
	class Employee
	{
		public string firstName = "";
		public string lastName = "";
		public int yearsOfExperience = 0;

		/// <summary>
		/// Prints the information for employee
		/// </summary>
		public void PrintEmployee()
		{
			Console.WriteLine($"{firstName} {lastName}: {yearsOfExperience} years");
		}
	}

	class Team
	{
		public Employee[] employees;
		int teamSize;

		//TODO: add a RemoveEmployee method
		/// <summary>
		/// Adds an additional employee to the team
		/// </summary>
		/// <param name="emp"></param>
		public void AddEmployee(Employee emp)
		{
			teamSize = employees.Length;
			Employee[] tempEmployees = employees;
			employees = new Employee[++teamSize];
			for (int i = 0; i < teamSize - 1; i++)
			{
				employees[i] = tempEmployees[i];
			}
			employees[teamSize - 1] = emp;			
		}

		/// <summary>
		/// Prints the average experience of the whole team
		/// </summary>
		public void PrintAverageExperience()
		{
			float sum = 0;
			foreach (Employee emp in employees)
			{
				sum += emp.yearsOfExperience;
			}
			Console.WriteLine($"Average experence: {sum / 2} years");
			
		}
	}
}
