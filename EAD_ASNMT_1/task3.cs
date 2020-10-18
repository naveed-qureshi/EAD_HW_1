using System;

namespace EAD_ASNMT_1
{
		class task3
		{
				static void Main ( String[] argvs )
				{
						float num;
						while (true)
						{
								try
								{
										Console.Write ("Enter a floating point Number: ");
										num = float.Parse (Console.ReadLine ());
										break;
								}
								catch (Exception e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										Console.WriteLine ("Enter a valid floating point number floating point Number: ");
								}
						}
						int choice;
						Console.WriteLine ("How you want to round the number?");
						while (true)
						{
								Console.WriteLine ("1. Traditional method");
								Console.WriteLine ("2. Banker's algorithm");
								Console.Write ("Your choice: ");
								try
								{
										choice = Convert.ToInt32 (Console.ReadLine ());
										break;
								}
								catch (Exception e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										Console.WriteLine ("Please select option 1 or 2.");

								}
						}
						switch (choice)
						{
								case 2:
										Console.WriteLine ("Using banker Algorithm...");
										Console.WriteLine ("The rounded value is: " + System.Convert.ToInt32 (num));
										break;
								case 1:
										Console.WriteLine ("Old method of rounding....");
										Console.WriteLine ("The rounded value is: " + Math.Round (value: num, digits: 0, MidpointRounding.AwayFromZero));
										break;
						}



				}
		}
}
