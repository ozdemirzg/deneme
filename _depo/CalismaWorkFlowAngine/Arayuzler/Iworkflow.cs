using System.Collections.Generic;

namespace CalismaWorkflowEngine.Arayuzler
{
    interface IWorkflow
    {
      void Add(IActivity activity);
      void Remove(IActivity activity);
      
      List<IActivity> GetActivities();

    }

}