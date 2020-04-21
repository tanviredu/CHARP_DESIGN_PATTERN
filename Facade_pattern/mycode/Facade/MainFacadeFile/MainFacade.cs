using Facade.Entities;
using Facade.Service;
namespace Facade.MainFacade
{
    public class MFacade
    {

        // here we only take what we need
        // first we will make sure that
        // it is accesable
        private readonly ConverterService _conservice;
        private readonly GroLookupService _geoservice;
        private readonly WeatherService _wservice;
        private readonly City _ct;
        private readonly State _st;

    // this  is the constructor function
        public MFacade()
        {
            // init the other three class
            _conservice = new ConverterService();
            _geoservice = new GroLookupService();
            _wservice = new WeatherService();

            
            _ct = new City();
            _st = new State();
            
        }

        // get the tmp from the weather service

        public int getWatherFromtheWservice(){
            var _dkcity = _ct.GetCityForZipCode("123");
            var _dkstate = _st.GetStateForZipCode("234");
            // dependency injection
            return _wservice.GetTempInfarenHite(_dkcity,_dkstate);
        }
    }
}