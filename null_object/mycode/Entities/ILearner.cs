using System;
namespace mycode.Entities
{
    // define a interface
    public interface ILearner
    {

            // this code must be executed
            // only the getter
            // you cant set it
            // the interafce has not set attribute
            // that means if you implement the class
            // then when you implement the class
            // the setter will be private setter
            // only the class thatimplement can set the value
            int Id { get;}
            string UserName { get;}
            int CourseCompleted { get;}

    }
}
