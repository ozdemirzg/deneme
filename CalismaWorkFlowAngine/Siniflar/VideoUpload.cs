using System.Threading;
using CalismaWorkflowEngine.Arayuzler;

namespace CalismaWorkflowEngine.Siniflar
{
    class VideoUpload :IActivity //Arabirim oluşturup using'e de arayüz name i ekledik.
    {
        public void Execute()
        {
           Upload();
        }

        public void Upload()
        {
            System.Console.WriteLine("Uploading video");
            Thread.Sleep(2000);
            System.Console.WriteLine("Video uploaded");
        }
    }
}