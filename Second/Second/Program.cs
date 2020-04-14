/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 4/14/2020
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Second
{
	class Program
	{
		public static void Main(string[] args)
		{
			int w;
			Console.Write("Enter any number: ");
			w = Convert.ToInt32(Console.ReadLine());
			if(w>5){
				Console.WriteLine("You're right!");
			}
			else{
				Console.WriteLine("Oops you didn't enter a number greater than 5");
			}
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
/*1. Write a program that checks if the number input from a user is even or odd.
2. Using both the nested if-else statement and switch statement write a program that checks if the number entered by a user is greater than 5.
3. Write a program that calculates the square of a number.*/

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}