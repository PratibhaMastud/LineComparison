using System;

namespace LineComparison
{
    class LineComparisonProb
    {
		public static void Main(String[] args)
		{
		    double length1;
            double length2;
            Random Number = new Random();
            double x1 = Number.Next(0, 6);
            double x2 = Number.Next(0, 6);
            double x3 = Number.Next(0, 6);
            double x4 = Number.Next(0, 6);
            double y1 = Number.Next(0, 6);
            double y2 = Number.Next(0, 6);
            double y3 = Number.Next(0, 6);
            double y4 = Number.Next(0, 6);
            length1 = (Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
            length2 = (Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3))));
            double line1 = length1; 
            double line2 = length2;
            Boolean equal = line1.Equals(line2);
            int compare = line1.CompareTo(line2);

            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("By Comparing the Both Lines are Same.");
            }
            else if (line1.Equals(line2) == true)
            {
                Console.WriteLine("Line are equal");
            }
            else 
            {
                Console.WriteLine("Line are not equal"); 
            }
        }
			
	}
}