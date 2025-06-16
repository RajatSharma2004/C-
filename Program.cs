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
      Console.WriteLine("Enter a number to check if its prime or not :");
      int n = Convert.ToInt32(Console.ReadLine());

      
      Maths m = new Maths();
      m.PrimeCheck(n);


      fact();//calling static function directlt in main function
      MainClass M = new MainClass();//for the not static method of main class
      M.checkEven();


      ReverseString.reverse();//different class static function

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

  class Maths
  {
    public void PrimeCheck(int n)
    {
      int number = n;
      bool isPrime = true;

      if (number <= 1)
      {
        isPrime = false;
      }
      else
      {
        for (int i = 2; i <= number / 2; i++)
        {
          if (number % i == 0)
          {
            isPrime = false;
            break;
          }
        }
      }
      if (isPrime)
      {
        Console.WriteLine($"{number} is prime");
      }
      else
      {
        Console.WriteLine($"{number} is not prime");
      }
  }
}

}