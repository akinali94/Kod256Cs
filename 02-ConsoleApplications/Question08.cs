using System;
namespace _02_ConsoleApplications
{
	public class Question08
	{
		public void Soru08()
		{
			/*Question 08: Write the program that can find which key is pressed
			 * using ConsoleKeyInfo method.
			 */

			ConsoleKeyInfo whichkey;
			Console.Write("Press a key on the keyboard: ");
			whichkey = Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("You pressed this key: " + whichkey.Key.ToString());
		}
	}
}

