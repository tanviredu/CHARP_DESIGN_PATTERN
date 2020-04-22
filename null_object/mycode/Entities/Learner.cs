using System;
namespace mycode.Entities
{
    public class Learner : ILearner
    {





        // implement the interface

        public int Id { get; private set;}
        public string UserName { get; private set; }
        public int CourseCompleted { get; private set; }




         // set the constructor to set the value
         // so when we call this class we can implement wih default value
        public Learner(int id,string userName,int courseCompleted) {
            Id = id;
            UserName = userName;
            CourseCompleted = courseCompleted;
            
        }

    }


}

