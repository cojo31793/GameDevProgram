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
			string showIntro;string a;string b; // all of these should be on one line and rename a and b to be more descriptive


			eqtoval = 0.55;
			a = "Welcome to the CloudTools Valuation Tool";b = "Copyright Wolverines & Co. All Rights Resevered.";

			showIntro = a + "\n" + b;
			System.Console.Write (showIntro);
		






			System.Console.Write(Environment.NewLine + "Enter the Growth Rate ");
			hold = System.Console.Read();
			
			System.Console.Write (Environment.NewLine + "Enter the Debt to Value Ratio");
			debttov = System.Console.Read();
			if (hold < 4) // notice how i made this look a little cleaner for you
			{
				growthRate = hold/100;
				System.Console.Write (Environment.NewLine + "The company's Growth Rate is " + growthRate);		
			}
			else
			{ 
				System.Console.Write (Environment.NewLine + "Error Invalid input");
			}

			calculateWACC = debttov * (.06 * (1 - 0.35) + (0.55 * 0.11));    
			// calculateWACC = debttov * (.06 (1 - 0.35) + (0.55 * 0.11));  
			// this was the original line...notice you forgot the extra * after the 0.06 ...this is important  

		}
	} 
}
