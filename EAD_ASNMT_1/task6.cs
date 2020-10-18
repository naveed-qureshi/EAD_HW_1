using System;

namespace EAD_ASNMT_1
{
		class task6
		{
				//suppose each subject has 3 credit hours
				const int CREDIT_HOURS = 3;
				static void Main ( String[] args )
				{
						double gpa = 0.0;
						int marks = 0;
						int totalSubjects = args.Length;

						for (int i = 0; i < totalSubjects; i++)
						{

								try
								{
										marks = Convert.ToInt32 (args[i]);
								}
								catch (Exception e)
								{
										Console.WriteLine (e.GetType () + " says " + e.Message);
										System.Environment.Exit (1);
								}
								switch (true)
								{
										case true when marks >= 85:
												gpa = gpa + CREDIT_HOURS *  4.0;
												break;
										case true when marks >= 80:
												gpa = gpa + CREDIT_HOURS *  3.7;
												break;
										case true when marks >= 75:
												gpa = gpa + CREDIT_HOURS *  3.3;
												break;
										case true when marks >= 70:
												gpa = gpa + CREDIT_HOURS *  3.0;
												break;
										case true when marks >= 65:
												gpa = gpa + CREDIT_HOURS *  2.7;
												break;
										case true when marks >= 60:
												gpa = gpa + CREDIT_HOURS *  2.3;
												break;
										case true when marks >= 59:
												gpa = gpa + CREDIT_HOURS *  2.0;
												break;
										case true when marks >= 58:
												gpa = gpa + CREDIT_HOURS *  1.7;
												break;
										case true when marks >= 55:
												gpa = gpa + CREDIT_HOURS *  1.3;
												break;
										case true when marks >= 50:
												gpa = gpa + CREDIT_HOURS *  1.0;
												break;
										case true when marks < 50:
												gpa = gpa + CREDIT_HOURS *  0.0;
												break;


								}

						}
						Console.WriteLine ("Your GPA is : " + gpa / (CREDIT_HOURS*totalSubjects));

				}

		}
}
