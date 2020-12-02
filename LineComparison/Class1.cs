using System;

public class Class1
{
	public static void Main(String[] args)
	{
		Console.WriteLine("Welcome to Line Comparison Computation Program");
		double length1;
		double length2;
		Random random = new Random();
		double x1 = random.Next(10, 1);
		double y1 = random.Next(10, 1);
		double x2 = random.Next(10, 1);
		double y1 = random.Next(10, 1);
		double y2 = random.Next(10, 1);
		double x3 = random.Next(10, 1);
		double x4 = random.Next(10, 1);
		double y3 = random.Next(10, 1);
		double y4 = random.Next(10, 1);

		length1 = (Math.sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
		length2 = (Math.sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3))));

		Double line1 = new Double(length1);
		Double line2 = new Double(length2);
		boolean equal = line1.Equals(line2);

		if (equal)
			Console.WriteLine("Lines are Equal");
		else
			Console.WriteLine("Lines are Not Equal");

	}
}
