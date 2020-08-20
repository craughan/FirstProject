using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
	class Circle
	{
		public Vector2 position;
		public float radius;

		public Circle(float posX, float posY, float rad)
		{
			position = new Vector2(0, 0);
			position.x = posX;
			position.y = posY;
			radius = rad;
		}

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
