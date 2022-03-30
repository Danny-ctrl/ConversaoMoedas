using System;
using System.Globalization;

namespace Moedas
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      decimal valor = 10567.23m;

      System.Console.WriteLine(
        Math.Round(valor)
      );
      System.Console.WriteLine(
        Math.Ceiling(valor)
      );
      System.Console.WriteLine(
        Math.Floor(valor)
      );


      System.Console.WriteLine(
         valor.ToString(
       "C",
        CultureInfo.CreateSpecificCulture("pt-BR")
       )
         );
    }
  }
}