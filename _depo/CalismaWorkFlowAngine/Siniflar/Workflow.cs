using System.Collections.Generic;
using CalismaWorkflowEngine.Arayuzler;

namespace CalismaWorkflowEngine.Siniflar
{
    class Workflow : IWorkflow
    {
        private List<IActivity> activities;

        // Constructor
        public Workflow()
        {
            activities = new List<IActivity>();
        }

        //
        public void Add(IActivity activity)
        {
            activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            activities.Remove(activity);
        }
        public List<IActivity> GetActivities()
        {
            return activities;
        }
    }

}