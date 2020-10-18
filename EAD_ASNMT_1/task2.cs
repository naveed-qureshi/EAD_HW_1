using System;
namespace EAD_ASNMT_1
{
		class task2
		{
				static void Main ( String[] args )
				{
						int num1, num2;
						char operat = '*';
						while (true)
						{
								try
								{
										Console.Write ("Enter first number: ");
										num1 = Convert.ToInt32 (Console.ReadLine ());
										break;
								}
								catch (FormatException e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										Console.WriteLine ("Please enter a valid Number");
								}
						}
						while (true)
						{
								try
								{
										Console.Write ("Enter second number : ");
										num2 = Convert.ToInt32 (Console.ReadLine ());
										break;
								}
								catch (FormatException e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										Console.WriteLine ("Please enter a valid Number");
								}
						}

						while (true)
						{
								try
								{
										Console.Write ("Enter operator (+,-,/,*,%): ");
										operat = Convert.ToChar (Console.ReadLine ());
								}
								catch (FormatException e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										Console.WriteLine ("Please enter a valid operator: ");
										continue;
								}
								switch (operat)
								{
										case '+':
												Console.WriteLine ($"The sum of {num1} and {num2} is {num1 + num2}");
												break;
										case '-':
												Console.WriteLine ($"The difference of {num1} and {num2} is {num1 - num2}");
												break;
										case '*':
												Console.WriteLine ($"The multiplication of {num1} and {num2} is {num1 * num2}");
												break;
										case '%':
												Console.WriteLine ($"The mod of {num1} and {num2} is {num1 % num2}");
												break;
										case '/':
												try
												{
														Console.WriteLine ($"The division of {num1} and {num2} is {num1 / num2}");
												}
												catch (DivideByZeroException e)
												{
														Console.WriteLine (e.GetType () + " " + e.Message);
												}

												break;
								}
								break;
						}
				}
		}
}
