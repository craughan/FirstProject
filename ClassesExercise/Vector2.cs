using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
	class Vector2
	{
		public float x { get; set; }
		public float y { get; set; }

		

		public float GetDistanceTo(Vector2 otherVec)
		{
			return (float)(Math.Sqrt((Math.Pow(otherVec.x - this.x, 2)) + Math.Pow(otherVec.y - this.y, 2)));
		}
	}
}
