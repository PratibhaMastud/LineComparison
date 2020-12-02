using System;

namespace Line_Comp
{
    class Program
    {
        static void Main(string[] args)
        {

				int firstX, firstY, secondX, secondY;
				double lengthOfLine;

				Console.WriteLine("Enter the length of X1");

				firstX = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter the length of Y1");

				firstY = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter the length of Y2");

				secondY = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Enter the length of X2");

				secondX = Convert.ToInt32(Console.ReadLine());

				lengthOfLine = Math.Sqrt((secondX - firstX) ^ 2 + (secondY - firstY) ^ 2);

				Console.WriteLine("length of line is : " + lengthOfLine);
			}

		}
	

}	
