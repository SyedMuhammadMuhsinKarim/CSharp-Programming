/*
 * Created by: SharpDevelop.
 */
 
using System;

namespace Binary_Search
{
	class Program
	{
		static int BinarySearch(int [] data, int first, int last, int search)
		{
			int mid = (first + last)/2;
			
			if(search == data[mid])
			{
				return mid;
			}
			
			if(search > data[mid])
			{
				return(BinarySearch(data, mid + 1, last, search));
			}
			else
			{
				return(BinarySearch(data, last, mid -1, search));
			}
		}
		
		public static void Main(string[] args)
		{
			int [] data = new int[8] {12, 24, 36, 48, 60};
			Console.Write("Enter Your Number:");
			int search = int.Parse(Console.ReadLine());
			int result = BinarySearch(data, 0, data.Length, search);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
