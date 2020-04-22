using System;
using mycode.Entities;
using mycode.Services;
using mycode.View;
namespace mycode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // execute everying

            // first we need a learner service
            LearnerService learnerservice = new LearnerService();
            // it will autometically init the learner repo
            // we get a implemented object now
            // because get current learner will send any of the two 
            // implemented class
            ILearner learner = learnerservice.getCurrentLearner();

            // init the object in view
            LearnerView view = new LearnerView(learner);
            view.RenderView();
        }
    }
}
