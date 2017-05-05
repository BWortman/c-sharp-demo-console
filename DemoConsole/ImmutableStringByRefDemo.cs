using System;

namespace DemoConsole
{
  class ImmutableStringByRefDemo
  {
    public void Execute()
    {
      var myString = "Marvin";
      Console.WriteLine("myString hash = " + myString.GetHashCode());
      Foo(myString);

      Console.WriteLine("myString = " + myString);
    }

    void Foo(string myString)
    {
      Console.WriteLine("myString hash = " + myString.GetHashCode());
      myString = "Hello " + myString;
    }
  }
}
