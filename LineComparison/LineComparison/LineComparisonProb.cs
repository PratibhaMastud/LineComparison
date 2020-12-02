using System;

namespace LineComparison
{
    class LineComparisonProb
    {
			Double[] lengths = new Double[2];
			double firstLine, secondLine;
			int firstX, firstY, secondX, secondY, thirdX, thirdY, fourthX, fourthY;

			void calculateLengthOfLine()
			{
				Random random = new Random();
				firstX = random.Next(10, 1);
				firstY = random.Next(10, 1);
				secondX = random.Next(10, 1);
				secondY = random.Next(10, 1);
				thirdX = random.Next(10, 1);
				thirdY = random.Next(10, 1);
				fourthX = random.Next(10, 1);
				fourthY = random.Next(10, 1);

				firstLine = Math.Sqrt(((secondX - firstX) * (secondX - firstX)) + ((secondY - firstY) * (secondY - firstY)));
				secondLine = Math.Sqrt(((fourthX - thirdX) * (fourthX - thirdX)) + ((fourthY - thirdY) * (fourthY - thirdY)));

				lengths[0] = Convert.ToDouble(firstLine);
				lengths[1] = Convert.ToDouble(secondLine);

				Double line1 = lengths[0];
				Double line2 = lengths[1];
				Console.WriteLine("Line1 length : {0}", lengths[0], " Line1 length : {0}", lengths[1]);

				if (line1.Equals(line2) == true)
				{
					Console.WriteLine("_____________________________________________________________________________");
					Console.WriteLine("Lines are equal to Length");
				}
				else
					Console.WriteLine("_____________________________________________________________________________");
				Console.WriteLine("Lines are not equal to Length");
			}

			public static void Main(String[] args)
			{
				LineComparisonProb lineComparison = new LineComparisonProb();
				lineComparison.calculateLengthOfLine();
			}
		}
	}
