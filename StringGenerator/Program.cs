// See https://aka.ms/new-console-template for more information

int number;
var text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
var random = new Random();
var result = "";
string[] commands = System.Environment.GetCommandLineArgs();

try
{
  if (int.TryParse(commands[1], out number))
  {
    result = new string(Enumerable.Repeat(text, number).Select(x => x[random.Next(x.Length)]).ToArray());
    System.Console.WriteLine(result);
  }
  else
  {
    System.Console.WriteLine("please input number");
  }
}
catch(System.IndexOutOfRangeException)
{
  System.Console.WriteLine("please input number");
}
