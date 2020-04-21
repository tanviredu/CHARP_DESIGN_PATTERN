
using Facade.MainFacade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is hwo we take multiple class
            // and multiple method
            // and use the function that we need
            // with dependency injection
            var newobj = new MFacade();
            Console.WriteLine(newobj.getWatherFromtheWservice());
        }
    }
}
