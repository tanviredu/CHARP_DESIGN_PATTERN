using Facade.Entities;

// so this method are same but from different services

namespace Facade.Service
{
    public class GroLookupService
    {
        // this is another service maymake similler command
        // but may be from different service
        public City GetCityForZipCode(string zipCode)
        {
            // a lookup would occur here
            return new City();
        }
        
        public State GetStateForZipCode(string zipCode)
        {
            // a lookup would occur here
            return new State();
        }

        public City GetCityForCoordinates(double longitude, double latitude)
        {
            // a lookup would occur here
            return new City();
        }
        
        public City GetStateByCapital(string capital)
        {
            // a lookup would occur here
            return new City();
        }

    }
}