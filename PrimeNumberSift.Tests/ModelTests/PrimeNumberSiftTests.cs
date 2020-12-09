using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrimeNumberSift;

namespace PrimeNumberSift.Tests
{
  [TestClass]
  public class PrimeNumberSiftTests
  {
    [TestMethod]
    public void PrimeNumbers_DeterminesDescendants_True()
    {
      //List<int> primeNumberList = new List<int> {};
      PrimeSift primeNumberTest = new PrimeSift(); 
      primeNumberTest.sifter(5); 
      Assert.AreEqual(1, primeNumberTest.primeNumberList[0]);
      Assert.AreEqual(2, primeNumberTest.primeNumberList[1]);
      Assert.AreEqual(3, primeNumberTest.primeNumberList[2]);
      Assert.AreEqual(5, primeNumberTest.primeNumberList[3]);
    }
  }
}