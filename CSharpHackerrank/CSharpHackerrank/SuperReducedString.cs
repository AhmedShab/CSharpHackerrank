using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHackerrank
{
	public class SuperReducedString
	{
		public void SolveSuperReducedString()
		{
			string s = "acdqglrfkqyuqfjkxyqvnrtysfrzrmzlygfveulqfpdbhlqdqrrqdqlhbdpfqluevfgylzmrzrfsytrnvqyxkjfquyqkfrlacdqj";
			string result = super_reduced_string(s);
			Console.WriteLine(result);
		}

		private static string super_reduced_string(string s)
		{
			int i = 1;

			while (i < s.Length)
			{
				// Found the pairs, remove them and start over
				if (s[i - 1] == s[i])
				{
					s = s.Remove(i - 1, 2);
					i = 1;
				}

				else
				{
					i++;
				}

			}

			return string.IsNullOrEmpty(s) ? "Empty String" : s;
		}

	}
}
