﻿using System;

namespace a
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double hold;
			double growthRate;
			double debttov; 
			double eqtoval;
			double WACC;
			string showIntro;string a;string b; // all of these should be on one line and rename a and b to be more descriptive


			eqtoval = 0.55;
			a = "Welcome to the CloudTools Valuation Tool";b = "Copyright Wolverines & Co. All Rights Resevered.";

			showIntro = a + "\n" + b;
			System.Console.Write (showIntro);
			System.Console.Write(Environment.NewLine + "Enter the Growth Rate ");
			hold = System.Console.Read();

			growthRate = hold/100;

			System.Console.Write (Environment.NewLine + "The company's Growth Rate is " + growthRate);		



			System.Console.Write (Environment.NewLine + "Enter the Debt to Value Ratio");
			debttov = System.Console.Read();


			WACC = debttov * (.06 * (1 - 0.35) + (0.55 * 0.11));  


			double valueOfHorizonPeriod = 1 / ((1 + WACC) * (1 + WACC)*(1 + WACC)*(1 + WACC)*(1 + WACC)*(1 + WACC)) * 10 / WACC - growthRate;


			double valueOfForcastPeriod = (10)/(1+WACC) + (12)/((1+WACC)* (1+WACC) * (1+WACC)) + (14)/((1+WACC) * (1+WACC)* (1+WACC) * (1+WACC)) + (16)/((1+WACC)* (1+WACC) * (1+WACC) * (1+WACC) * (1+WACC)) + (18)/((1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)) + (20)/((1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)*(1+WACC)*(1+WACC));

			double valueOfCloudTools = valueOfForcastPeriod + valueOfHorizonPeriod;


			System.Console.Write (Environment.NewLine + "The Value Of Cloud Tools" + valueOfHorizonPeriod);


			// calculateWACC = debttov * (.06 (1 - 0.35) + (0.55 * 0.11));  
			// this was the original line...notice you forgot the extra * after the 0.06 ...this is important  


		}
	}
}
