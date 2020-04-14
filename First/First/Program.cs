/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 4/14/2020
 * Time: 8:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace First
{
	class Program
	{
		public static void Main(string[] args)
		{
			int v;
			Console.Write("Enter a number: ");
			v = Convert.ToInt32(Console.ReadLine());
			if (v % 2 ==0){
				Console.WriteLine("You entered an even number");
			}
			else if (v % 2 != 0){
				Console.WriteLine("You entered an odd number");
			}
			
			
			
			Console.WriteLine("Hello World!");

/*1. Write a program that checks if the number input from a user is even or odd.
2. Using both the nested if-else statement and switch statement write a program that checks if the number entered by a user is greater than 5.
3. Write a program that calculates the square of a number.*/

			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}