using System;
namespace mycode.Entities
{
    public class NullLearner:ILearner
    {


        // this is another inherited class
        // but this is used for null refrence
        // it is filled with default value
        // so it wil not return any  null refrence
        public int Id { get; } = -1;
        // remember the sign 
        public string UserName => "Anonymous";
        public int CourseCompleted { get; } = 0;


    }
}
