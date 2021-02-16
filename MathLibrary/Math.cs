using System;
namespace MathLibrary {
	class Math {

		public static int Add(int a, int b) {
			return a + b;
		}

		public static int Subtract(int a, int b) {
			return a - b;
		}

		public static int Multiply(int a, int b) {
			return a * b;
		}

		public static int Divide(int a, int b) {
			return a / b;
		}




		// Create the modulo method.
		// Takes two integers, divides the second into the first and returns the remainder of the integer division.

		public static int Mod(int a, int b) {
			return a % b;
		}

		public static int Modulo(int a, int b) {
			return a - (a / b * b);
		}


		/*
				Create a method that takes two integers and raises the first integer to the power of the second integer.

					Power(2, 3) = 2*2*2
					Power(5, 4) = 5*5*5*5
		*/

		public static int Power(int a, int b) {


			var x = (b == 0) ? 0 : a;
			for (var idx = 1; idx < b; idx++) {
				x *= a;
			};
			return x;

			/*
			

			
			 */





			/* 
			// Doug's Way
			var answer = 1;
			for (var idx = 0; idx < b; idx++) {
				answer *= a;
			};
			return answer;

			// Fails when b == 0
			*/

		}



	}
}
