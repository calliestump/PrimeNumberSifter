using System;
using System.Collections.Generic;

namespace PrimeNumberSift
{
  public class PrimeSift
  {
    public List<int> primeNumberList = new List<int> {};
    public void sifter(int input)
    {
      for (int i = 1; i <= input ; i++) {
        int count = 0; 
        for (int j = 1; j <= i; j++) {
          if (i % j == 0) {
            count++; 
          }
        }
        if (count == 2) {
          primeNumberList.Add(i); 
        }
      }
    }
  }
}





