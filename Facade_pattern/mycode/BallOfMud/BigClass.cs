using System;

namespace BallOfMud
{   

    // this big class have  a lot of method
    class BigClass
    {


        // this is a private property
        // we will set with another publi function
        private int _i;



        // this is getter
        public int GetValueA()
        {
            // some work
            return _i;
        }


        // this is another  function
        public string GetValueB()
        {
            return "Ball of Mud";
        }


        // this is setter
        public void SetValueI(int i)
        {
            _i = i;
        }


        // increment 
        // its also a setter
        // you dont have to passparameter
        // increase the value
        public void IncrementI()
        {
            _i++;
        }

        // decrement 
        // its also a setter
        // you dont have to passparameter
        // decrement the value
        
        public void DoSomething()
        {
            _i--;
        }


        // setter increment any number
        public int AddToI(int addMe)
        {
            _i +=  addMe;
            return _i;
        }


        // emplty function
        public void UnrelatedMethod()
        {
            // do something unrelated
        }


        // another function
        public void AddedThisMethodLater()
        {
            // calls a db for a number
            
            int theNumber = 12;
            _i += theNumber;
        }


        // another method
        public void DecrememntI()
        {
            _i--;
        }
       
    }
}
