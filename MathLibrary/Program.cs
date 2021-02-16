using System;

namespace MathLibrary {
	class Program {
		static void Main(string[] args) {

			// var math = new Math(); // Do not need to 
			var answer = Math.Add(1, 2);
			Console.WriteLine($"{answer}\n");

			var answerS = Math.Subtract(1, 2);
			Console.WriteLine($"{answerS}\n");

			var answerM = Math.Multiply(6, 2);
			Console.WriteLine($"{answerM}\n");

			var answerD = Math.Divide(9, 3);
			Console.WriteLine($"{answerD}\n");

			var answerO1 = Math.Mod(7, 2);
			Console.WriteLine($"{answerO1}\n");

			var answerO2 = Math.Mod(13, 5);
			Console.WriteLine($"{answerO2}\n");

			var answerO3 = Math.Mod(1234, 13);
			Console.WriteLine($"{answerO3}\n");




			var answer1 = Math.Power(2, 2);
			Console.WriteLine($"pow {answer1}\n");

			var answer2 = Math.Power(5, 5);
			Console.WriteLine($"{answer2}\n");

			var answer3 = Math.Power(2, 0);
			Console.WriteLine($"{answer3}\n");

			/*

			var answer1 = Math.Modulo(7, 2);
			Console.WriteLine($"{answer1}\n");

			var answer2 = Math.Modulo(13, 5);
			Console.WriteLine($"{answer2}\n");

			var answer3 = Math.Modulo(1234, 13);
			Console.WriteLine($"{answer3}\n");


			*/

		}
	}
}
