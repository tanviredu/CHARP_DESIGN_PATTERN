using System;
namespace BallOfMud
{
    public class Program
    {

        static void Main(string[] args){

            // insted of the BigClass we take the
            // BigClassFacade

            var _bigclassFacade = new BigFacade();
            _bigclassFacade.IncreasebyNumber(100);
            _bigclassFacade.DecresebyNumber(50);
            Console.WriteLine(_bigclassFacade.GetCurrentValue());
        }
        
    }
}