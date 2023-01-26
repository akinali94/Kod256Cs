using System;
namespace _02_ConsoleApplications
{
	public class Question07
	{
		public void Soru07()
		{
			/*Question 07: Write a program that write black text on a white background
			 * using Backgroundcolor and Foregroundcolor methods.
			 */

			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("It is an example for color change on Console.");
		}
	}
}

