using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
	class Vector2
	{
		public float x, y;

		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public float GetDistanceTo(Vector2 otherVec)
		{
			return (float)(Math.Sqrt((Math.Pow(otherVec.x - this.x, 2)) + Math.Pow(otherVec.y - this.y, 2)));
		}
	}
}
