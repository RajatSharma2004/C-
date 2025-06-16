using System;

namespace MyProgram
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello ! ");
      Console.Write("I am Rajat ");
      Console.WriteLine("Bye");

      fact();



    }
    public static void fact()
    {
      Console.Write("Enter a number ");
      int number = Convert.ToInt32(Console.ReadLine());

      int factorial = 1;
      for (int i = 1; i <= number; i++)
      {
        factorial *= i;
      }
      Console.WriteLine("The factorial of number is : " + factorial);

    }
    
  }
}