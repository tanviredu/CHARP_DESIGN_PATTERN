using System;
using mycode.Entities;
namespace mycode.View
{
    public class LearnerView
    {


        // this is used  as view  function
        // it will format and 
        // return formatted string

        // make a global Ilearner object
        // we need the spefic object
        // for and format its data
        private readonly ILearner _learner;

        public LearnerView(ILearner learner) {


            // view object takes  a learner object
            // and we did this to make this global
            _learner = learner;
        
        }

        public void RenderView()
        {
            Console.WriteLine($"Username is {_learner.UserName}");
            Console.WriteLine($"Courses Complete {_learner.CourseCompleted}");
        }
    }
}
