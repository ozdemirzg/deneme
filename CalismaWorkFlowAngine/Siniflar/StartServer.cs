using System.Threading;
using CalismaWorkflowEngine.Arayuzler;

namespace CalismaWorkflowEngine.Siniflar
{
    class StartServer :IActivity
    {
     public void Execute()
        {
            Start();
        }
    
        public void Start()
        {
            Thread.Sleep(2000);
            System.Console.WriteLine("Server started");
        }
    }
}