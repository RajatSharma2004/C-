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

      fact();//calling static function directlt in main function
      MainClass M = new MainClass();//for the not static method of main class
      M.checkEven();


    }
    public static void fact()
    {
      Console.Write("Enter  number to get its factorial : ");
      int number = Convert.ToInt32(Console.ReadLine());

      int factorial = 1;
      for (int i = 1; i <= number; i++)
      {
        factorial *= i;
      }
      Console.WriteLine("The factorial of number is : " + factorial);

    }
    public void checkEven()
    {
      Console.Write("Enter a number to check if its even or not : ");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number % 2 == 0)
      {
        Console.WriteLine(number + " is even");
      }
      else
      {
        Console.WriteLine(number + " is odd");
      }
    }
  }


  
}