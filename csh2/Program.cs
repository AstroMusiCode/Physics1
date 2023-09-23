using System;
using System.Numerics;
using static System.Math;

namespace Programs 
{
	public class Program 
	{
		public static void Main(string[] args)
		{
			Object[] obj = new object[3];
			Vector2 vi = new Vector2(0, 0);
			Vector2 vf = new Vector2(0, 0);
			Vector2 d = new Vector2(0, 0);
			const float ay = -9.8f; float t = 0f;
			
			
		}

		private static Object[] task1(Vector2 vi, Vector2 vf, float t, Vector2 d, float ay) 
		{
			Object[] obj = new object[3];
			Console.WriteLine("Initial X Velocity: ");
			
			vi.X = float.Parse(Console.ReadLine());
			Console.WriteLine("Initial Y Velocity: ");
			
			vi.Y = float.Parse(Console.ReadLine());
			Console.WriteLine("Time: ");
			t = float.Parse(Console.ReadLine());
			
			vf.X = vi.X;
			vf.Y = vi.Y + ay * t;
			d.X = vi.X * t;
			d.Y = (vi.Y * t) + 0.5f * ay * (float)(Math.Pow(t, 2));

			obj[0] = vi;
			obj[1] = magnitude(vi);
			obj[2] = d;
			return obj;
		}
		private static Vector2 task2(Vector2 v)
		{
			Console.WriteLine("Total Velocity: ");
			float magnitude = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Angle: ");
			float direction = float.Parse(Console.ReadLine());
			
			v.X = magnitude *(float) Math.Cos(direction);
			v.Y = magnitude * (float)Math.Sin(direction);
			
			return v;
		}
		private static double magnitude(Vector2 v) 
		{
			return Convert.ToDouble(Math.Sqrt((Math.Pow(v.X, 2) + Math.Pow(v.Y, 2))));
		}	
		private static double direction(Vector2 v) 
		{
			return Math.Atan(v.Y / v.X);
		}
	}
}