using System;
namespace _02_ConsoleApplications
{
	public class Question05
	{
		public void Soru05()
		{
            /*Question 5: Write a program to find the sum and average of four numbers entered by the user.
			*/

            int a, b, c, d, sum, ave;
			Console.Write("Enter the 1.number: ");
			a = Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter the 2.number: ");
			b = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the 3.number: ");
            c = Int16.Parse(Console.ReadLine());
            Console.Write("Enter the 4.number: ");
            d = Int16.Parse(Console.ReadLine());

			sum = a + b + c + d;
			ave = sum / 4;

			Console.WriteLine("The sum of the four number: {0}", sum);
            Console.WriteLine("The average of the four number: " + ave);

        }
	}
}

