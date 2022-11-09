using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> list1 = Enumerable.Range(1, 10);
			foreach (int i in list1)
			{
				Console.WriteLine(i);
			}
			IEnumerable<int> list2 = Enumerable.Range(10, 6);
			foreach (int i in list2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
