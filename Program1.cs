using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string showIntro;string a;string b;
			a = "Welcome to the CloudTools Valuation Tool";b = "Copyright Wolverines & Co. All Rights Resevered.";

			showIntro = a + "\n" + b;
			System.Console.Write (showIntro);
			double hold;
			double growthRate;
			double calculateWACC;


			System.Console.Write(Environment.NewLine + "Enter the Growth Rate ");
			hold = System.Console.Read();
			if (hold < 4)
			{growthRate = hold/100;
				System.Console.Write (Environment.NewLine + "The company's Growth Rate is " + growthRate);
					
			}
			else{ System.Console.Write (Environment.NewLine + "Error Invalid input");
					
				

			}

		}
	} 
}
