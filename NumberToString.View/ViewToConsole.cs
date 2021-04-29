using System;
using NumberToString.Domain.Interfaces;

namespace NumberToString.View
{
    public class ViewToConsole : IView
    {
        public void PrintText(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }

        public string InputUser()
        {
            return Console.ReadLine();
        }
    }
}
