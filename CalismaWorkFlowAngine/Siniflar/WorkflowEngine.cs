using System;
using System.Collections.Generic;
using CalismaWorkflowEngine.Arayuzler;

namespace CalismaWorkflowEngine.Siniflar
{
    class WorkflowEngine
    {
       private List<IActivity> activities; // field / alan ise küçük harf uygun olur

        public WorkflowEngine()
        {
            activities = new List<IActivity>();

        }
        public void Run(IWorkflow workflow)
        {
            activities = workflow.GetActivities();

            foreach (var a in activities)
            {
                a.Execute();
            }

        }

    }
}