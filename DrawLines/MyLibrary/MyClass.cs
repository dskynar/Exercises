using System;

namespace MyLibrary
{
	public class MyClass
	{
		public MyClass ()
		{
		}

		public int Divide (int number1, int number2)
		{
			int result;
			try {
				result = number1 / number2;
			} catch (DivideByZeroException) {
				result = -1;
			}
			return result;
		}
	}
}

