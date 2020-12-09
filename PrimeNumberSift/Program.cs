using System;
using System.Collections.Generic;
using PrimeNumberSift;

public class PrimeSiftProgram
{
  public static void Main()
  {
    PrimeSift primeNumberTest = new PrimeSift(); 
    Console.WriteLine("Enter a Number");
    string input = Console.ReadLine();
    int inputNumber = int.Parse(input);
    primeNumberTest.sifter(inputNumber);
    for (int i = 0; i < primeNumberTest.primeNumberList.Count; i++) {
      Console.Write(primeNumberTest.primeNumberList[i]);
      if (i != primeNumberTest.primeNumberList.Count) {
        Console.Write(", ");
      }
    }
  }
}
