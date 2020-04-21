namespace Facade.Entities
{
    public class City
    {
        // his city will be called from a zip code
        // return the city instance
        // City type return
        public City GetCityForZipCode(string zipcode){
                return new City();

        }

        public string Name = "redmond";
        
    }
}