using System;
using System.Threading.Tasks;

namespace DemoConsole
{
  public class AsyncAwaitDemo
  {
    public async void Execute()
    {
      var name = "Marvin";
      var salutation = await GetSalutation(name);
      Console.WriteLine("Salutation = " + salutation);
    }

    public async Task<string> GetSalutation(string name)
    {
      await Task.Delay(5000);
      return "Hello " + name;
    }
  }
}