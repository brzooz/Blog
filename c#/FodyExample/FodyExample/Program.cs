using System;

namespace FodyExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var viewModel = new MyViewModel
            {
                Text = "text",
                Count = 1
            };
        }
    }
}