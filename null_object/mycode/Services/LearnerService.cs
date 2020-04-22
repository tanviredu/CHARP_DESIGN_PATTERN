using System;
using mycode.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace mycode.Services
{
    public class LearnerService
    {
        // learner service will init the learner repo
        // this is just like a Facade pattern 
        // we init the Learner Repo and 
        // and called the getLearner() in  a different name
        // dependency injection
        // with id=0 that we call curent learner
        // you can set the id anything you want
        // and we always return the ILearner object 
        // because thats our interface


        // init the repo first

        readonly LearnerRepo _repo = new LearnerRepo();
        public ILearner getCurrentLearner()
        {
            var learner_id = 1;
            return _repo.GetLearner(learner_id);
        }

    }
}
