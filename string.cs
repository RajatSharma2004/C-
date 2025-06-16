using System;
namespace MyProgram
{
  class ReverseString
  {
    public static void reverse()
    {
      Console.Write("Enter a string: ");
      string input = Console.ReadLine();
      string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine($"Reversed string: {reversed}");
    }
  }
}