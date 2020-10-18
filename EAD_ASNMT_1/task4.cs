using System;

namespace EAD_ASNMT_1
{
		class task4
		{
				static void Main ( String[] args )
				{
						int x = 10;
						int y = 20;
						Console.WriteLine ($"Before swap x = {x}, y = {y}");
						swap (ref x, ref y);
						Console.WriteLine ($"After swap x = {x}, y = {y}");

				}
				public static void swap ( ref int num1, ref int num2 )
				{
						int temp = num1;
						num1 = num2;
						num2 = temp;
				}
		}
}
