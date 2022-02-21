using System;

namespace UsemKalitim
{
    class Installer
    {
        private Logger _logger; // field
        //

         public Installer()  //bunu yazdığında parametre vermesende çalışıyor.
        {

        }
        public Installer(Logger logger)
        {
            _logger = logger;
        }

          public void Start()
        {
            Console.WriteLine("Yükleme başladı");
            _logger.LogInfo("Başladı");

            if (3 > 2)
                _logger.LogError("Hata oluştu");
        }

    }

}
