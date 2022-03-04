using System;
using CalismaWorkflowEngine.Siniflar;

namespace CalismaWorkFlowAngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            var v = new VideoUpload();
            var s = new StartServer();

            workflow.Add(v);
            workflow.Add(s);

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }
            
        
    }
}
