using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHackerrank
{
	public class MinMaxSum
	{
		public class MiniMaxSum
		{
			public string SolveMinMax()
			{
				IList<long> results = new List<long>();
				// string[] arr_temp = Console.ReadLine().Split(' ');
				int[] arr = { 1, 2, 3, 4, 5 };

				foreach (var number in arr)
				{
					results.Add(number);
				}

				long sum = results.Sum(n => n);

				long min = sum - results.Max(n => n);
				long max = sum - results.Min(n => n);


				return ($"{min} {max}");
			}
		}
	}
}
