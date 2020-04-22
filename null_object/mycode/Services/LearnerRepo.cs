using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using mycode.Entities;

namespace mycode.Services
{
    public class LearnerRepo
    {
        // this clas hold the repository 
        // of the learner id,name,and the
        // course mark
        // this is like a repo can be database or anything
        // we are using in memory
        // in a list
        // so make a list and in that list we store the learner object
        List<Learner> _learners = new List<Learner>();


        // this act as a repository
        // of the data
        public LearnerRepo()
        {
            // constructor add thi default value when added
            _learners.Add(new Learner(1, "devid", 83));
            _learners.Add(new Learner(2, "Tanvir", 59));
            _learners.Add(new Learner(3, "Ornob", 56));
        }



        // now we apply the get learner
        // and also applt the Null Learner functionality
        // if any thing is called that is not in the repo
        // so we send the NullLearner insted of exception
        // so we get a default value
        // and the main focus is 
        // remember we return a NullLearner 
        // which is a implementation of Ilearner
        // so we need to set the Ilearner as a return Type

        public ILearner GetLearner(int id)
        {
            // check if the learner exists
            // by searcing the list
            // the expression in Any() function is a generic is  Linq
            // it will search for the id
            // in the list 
            // studen tLinq
            bool learnerExists = _learners.Any(l => l.Id == id);

            if (learnerExists)
            {
                // return this 
                return _learners.FirstOrDefault(l => l.Id == id);

            }

            // now this is important 
            // if the user not found it we 
            return new NullLearner();
        }


    }
}
