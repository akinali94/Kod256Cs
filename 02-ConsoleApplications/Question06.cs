using System;
namespace _02_ConsoleApplications
{
	public class Question06
	{
		public void Soru06()
		{
			/*Question 6: Write the program that finds the ASCII code of the key
			*pressed on the keyboard using Read Method.
			*/

			int key;
			char keychar;

            Console.Write("Please, press a key: ");
            keychar = Convert.ToChar(Console.Read());
            key = Console.Read();


            Console.WriteLine("The pressed key: {0}", keychar);
            Console.WriteLine("ASCII code equivalent of the pressed key: {0}", key);

            /*Read is used to read only single character from the standard output device,
             *while Console.ReadLine is used to read a line or string from the standard
             *output device.
             */

        }
	}
}

