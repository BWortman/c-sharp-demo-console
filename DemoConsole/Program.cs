using System;

namespace DemoConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      new ImmutableStringByRefDemo().Execute();
      new AsyncAwaitDemo().Execute();

      Console.WriteLine("Hit Enter to exit.");
      Console.ReadLine();
    }
  }
}
