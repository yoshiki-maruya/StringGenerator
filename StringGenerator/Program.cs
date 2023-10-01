using System;
using System.Windows.Forms;

namespace StringGenerator
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = string.Empty;
            try
            {
                if (int.TryParse(args[1], out int number))
                {
                    result = new string(Enumerable.Repeat(text, number).Select(x => x[random.Next(x.Length)]).ToArray());
                    Clipboard.SetText(result);
                    Console.WriteLine(result);
                    Console.WriteLine("Copy to Clipboard");
                }
                else
                {
                    Console.WriteLine("please input number");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("please input number");
            }
        }
    }
}
