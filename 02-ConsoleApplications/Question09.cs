using System;
namespace _02_ConsoleApplications
{
	public class Question09
	{
		public void Soru09()
		{
			/* Question 09: Write a program that print randomly 100 asterisk(*)
			 * on the console using SetCursorPosition method.
			 */

			Random place = new Random();
			//Console.SetWindowSize(30, 20); //not supported on Mac
			for(int i =0; i<100; i++)
			{
				int row = place.Next(1, 19);
				int column = place.Next(1, 19);
				Console.SetCursorPosition(column, row);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("*");
				//System.Threading.Thread.Sleep(150);  //not supported on Mac

			}



		}
	}
}

