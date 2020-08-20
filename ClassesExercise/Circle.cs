using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
	class Circle
	{
		public Vector2 position { get; set; }
		public float radius { get; set; }

		public bool ContainsPoint(Vector2 point)
		{
			return point.GetDistanceTo(position) <= radius;
		}

		public bool CheckOverlap(Circle otherCircle)
		{
			return otherCircle.position.GetDistanceTo(this.position) <= otherCircle.radius + radius;
		}
	}
}
