namespace Usem.OrnekSiniflar
{
    class KisiTest  //'static class'yaparsan bunu kullanıma kapatırsın(new li yaptığımız yaptırmaz yani).kopya alamazsın benden diyor yani.//AMA bununla . dierek işler yaptırabiliyorsun.
    {
        public static int nufus;

        public readonly string ad;
        public int id;

         // Constructor
        public KisiTest()
        {
            Dogdu();   // implementation detail / gerçekleştirme  ayrıntısı
           //nufus++;
        }

         public static void Dogdu()  
         {
             nufus++;
         }
        
    }

}
/* 
    //Bu kısmıMainde yazmıştık.
             var kT = new KisiTest();  //bunda atadan arttırma yapamazsın.  //static olduğunda
            
            KisiTest.Dogdu();
           
            var kT2 = new KisiTest();  //bunda doğan kişiyle artarken sende aradan arttırma yapabilirsin. //contructo olduğunda
            KisiTest.Dogdu();    //kT.Dogdu ile yapaazsın burda.çünkü olduğu classta static Dogdu().
            System.Console.WriteLine(KisiTest.nufus);

            /* // Math static? evet
            Math.Abs();

            // Random ? static mi hayır
            Random r = new Random();
 */
            /*  //Burada static olduğu için alttaki iki satırda olabı yazamazsın.3.satırdaki gibi yapabilirsin.
              var m = new Math();
            m.Max();

            Math.Max(1, 3); */

            // //var t = new Thread(); //bunda ilk hatayı using te verecek.onu başa ekle önce.Hala hata veriyorsa static class demek.
 