using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHackerrank
{
	public class TimeConversion
	{
		public void SolveTimeConversion()
		{
			string s = "07:05:45PM";

			string result = timeConversion(s);
			Console.WriteLine(result);
		}

		private static string timeConversion(string s)
		{
			DateTime time = DateTime.Parse(s);

			return $"{time.ToString("HH:mm:ss")}";
		}
	}
}
