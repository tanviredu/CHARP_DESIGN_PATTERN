namespace BallOfMud
{
    public class BigFacade
    {

        // we need to make the object globally
        // not just inside th econstructor

    
        private readonly BigClass _bigclass;
        // now it an be accesable by all method i the class
        public BigFacade()
        {
            _bigclass = new BigClass();
            // setting the initial value to 0
            _bigclass.SetValueI(0);

        }




        // now we make out own method
        // we need this function only from the big class
        public void IncreasebyNumber(int number){
            // dependency injection
            _bigclass.AddToI(number);
        }

        public void DecresebyNumber(int number){
            // dependency injection
            // same method but we 
            //change the implementation
            // we can change it like this
            _bigclass.AddToI((-1*number));
        }




        // thats all the function that we needed
        public  int GetCurrentValue(){
            return _bigclass.GetValueA();
        }



    }
}