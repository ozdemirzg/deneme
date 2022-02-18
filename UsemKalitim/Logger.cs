namespace UsemKalitim
{
    class Logger
    {
        public void LogInfo(string mesaj)
        {
            System.Console.WriteLine("Info: " + mesaj);
        }

                public void LogError(string mesaj)
        {
            System.Console.WriteLine("ERROR: " + mesaj);
        }
    }

}