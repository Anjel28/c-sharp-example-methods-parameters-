using System;
class Program
{
    /*  static void PrintMessage()
      {
          Console.WriteLine("Hello, this is a simple method");
      }*/
    /*static void PrintName(string name)
   {
       Console.WriteLine("Hello," + name);
   }*/
    /*static int square(int num)
     {
         return num * num;
     }*/
    /* public static int AddNumbers(int a, int b)
     {
         return a + b;
     }*/
    /* static public (int, int) GetMinMax(int[] numbers)
      {
          int Min = numbers.Min();
          int Max = numbers.Max();
          return (Min, Max);
      }*/
    static public void Greet(string name = "Guest")
    {
        Console.WriteLine("Hello, " + name);
    }
    static void Main(string[] args)
    {
        Greet();
        /*int[] numbers = { 5, 2, 9, 1, 7, 3 };
      var ( Min,  Max) = GetMinMax( numbers);
        Console.WriteLine($"Min: {Min}, Max: {Max}"); */
        /* int a = 5;
         int b = 6;
         int AddNumbers = a + b;
         Console.WriteLine($"The add numbers of  is {a+b}");*/
        /* int num = 4;
         int squareNumber = square(num);
         Console.WriteLine($"The square of {num} is {squareNumber}");*/
        // PrintName("John");
        //  PrintMessage();
    }
}