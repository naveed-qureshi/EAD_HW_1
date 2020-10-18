using System;

namespace EAD_ASNMT_1
{
		class Program
		{
				static void Main ( string[] args )
				{
						int temperature;
						while (true)
						{
								try
								{
										Console.Write ("Enter temperature in celsius: ");
										temperature = Convert.ToInt32 (Console.ReadLine ());
										break;
								}
								catch (FormatException e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
								}
						}
						switch (true)
						{
								case true when temperature < 0:
										Console.WriteLine ("Freezing weather");
										break;
								case true when temperature < 10:
										Console.WriteLine ("Very Cold weather");
										break;
								case true when temperature < 20:
										Console.WriteLine ("Cold weather");
										break;
								case true when temperature < 30:
										Console.WriteLine ("Normal in Temp");
										break;
								case true when temperature < 40:
										Console.WriteLine ("Its Hot");
										break;
								case true when temperature >= 40:
										Console.WriteLine ("Its Very Hot");
										break;
						}

				}
		}
}
