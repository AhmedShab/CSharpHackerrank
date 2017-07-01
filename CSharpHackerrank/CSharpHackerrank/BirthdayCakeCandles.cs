using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHackerrank
{
	public class BirthdayCakeCandles
	{
		private static IList<int> heights = new List<int>();
		public void SolveCakeCandle()
		{
			/*
			 *	4
				3 2 1 3
			 */
			//int n = Convert.ToInt32(Console.ReadLine());
			//string[] ar_temp = Console.ReadLine().Split(' ');
			int[] ar = {3, 2, 1, 3};
			int result = birthdayCakeCandles(ar);
			Console.WriteLine(result);
		}

		private int birthdayCakeCandles(int[] ar)
		{
			GenerateListOfHeights(ar);

			int heightest = heights.Max(m => m);

			int count = heights.Count(c => heightest == c);


			return count;

		}

		private void GenerateListOfHeights(int[] ar)
		{
			foreach (var height in ar)
			{
				heights.Add(height);
			}
		}
	}
}
