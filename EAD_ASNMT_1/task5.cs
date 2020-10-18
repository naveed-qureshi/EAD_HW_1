using System;

namespace EAD_ASNMT_1
{
		class Objects
		{
				static int objectCount = 0;
				public Objects ( )
				{
						objectCount++;
				}
				public static int getCount ( )
				{
						return objectCount;
				}
		}
		class task5
		{
				static void Main ( String[] args )
				{
						Objects o1 = new Objects ();
						Objects o2 = new Objects ();
						Objects o3 = new Objects ();
						Objects o4 = new Objects ();
						Objects o5 = new Objects ();
						Objects o6 = new Objects ();
						Console.WriteLine ($"Total Objects are: {Objects.getCount ()}");
				}
		}
}
