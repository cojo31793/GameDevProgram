using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		


			double hold;
			double growthRate;
			double debttov;
			double eqtoval;
			double calculateWACC;
			string showIntro;string a;string b;


			eqtoval = 0.55;
			a = "Welcome to the CloudTools Valuation Tool";b = "Copyright Wolverines & Co. All Rights Resevered.";

			showIntro = a + "\n" + b;
			System.Console.Write (showIntro);
		






			System.Console.Write(Environment.NewLine + "Enter the Growth Rate ");
			hold = System.Console.Read();
			System.Console.Write (Environment.NewLine + "Enter the Debt to Value Ratio");
			debttov = System.Console.Read ();
			if (hold < 4)
			{growthRate = hold/100;
				System.Console.Write (Environment.NewLine + "The company's Growth Rate is " + growthRate);
					
			}
			else{ System.Console.Write (Environment.NewLine + "Error Invalid input");
				
			}

			calculateWACC = debttov*(.06 (1 - 0.35) + 0.55 * 0.11);


		}
	} 
}
