using System;
using System.Collections.Generic;
using System.Threading;

namespace Usem.Oyunlar
{
    class MuzikCalar
    {
        // Dictionary KEY , VALUE 
         //static eklemezsen başlarına aşağıda görmüyor.
        static Dictionary<string, string> album = new Dictionary<string, string>();  // Dictionary<string, string> album;
                                                                              //int a; gibi bu üstteki.
        static Stack<string> gecmis = new Stack<string>(); // int a = 3 gibi düşün bunu!
        static bool durum;    // Çalıyor : TRUE , Durdu: FALSE
        static bool acik = true;
        static string calanParca;


        public static void Baslat()
        { 
            Console.Clear();
            AlbumOlustur();
            //Bayrak için açtık'While'.Devam mı Tamam mı demek için.
            while (acik)     // progrsmın çalışır halde kalmasını sağlıyor.
            {
                if(durum)
                {
                    GosterPanel(); 
                    TercihPanelDegerlendir(TercihPanel());
                    //Bitiyor döngünün başına gidiyor.
                }
                else
                {
                    GosterListe();
                    TercihListeDegerlendir(TercihListe());
                    //Bitiyor döngünün başına gidiyor.
                }           
            }
            Console.Clear();
             foreach (var item in gecmis)
            {
                album.TryGetValue(item,out string parca);
                Console.WriteLine();
                Console.WriteLine(item + "-" + album[item]);
            }
            
        }

        private static void TercihListeDegerlendir(string tercih)
        {
            // Çıkış mı? Parça Seçim mi?

            //
               if (tercih == "0")
            {
                Console.WriteLine("Kapatılıyor");
                acik = false;
            }
            else
            {
                calanParca = tercih;
                DurCalGecis();
            }


        }

        private static void TercihPanelDegerlendir(string tercih)
        {
              switch (tercih)    //  Çal(1)   Dur(2)   Çıkış (0)
            {
                case "0":Console.WriteLine("Kapatılıyor...");
                    acik = false;
                    break;
                case "1":
                if(durum == true)
                {
                    Console.WriteLine("Zaten çalıyor...");
                    Thread.Sleep(2000);  //üste eklediğimiz Treading sayesinde tanımladık. 3 sainye görünüp kaybolacak yazdırdığımız zaten çalıyor.
                }
                    DurCalGecis();
                    break;   
                case "2":
                    CalDurGecis();
                    break;             
            }        
        }

        private static string TercihListe() //return yaptı string yazdık.
        {
            string tercih ="";
            bool devam = true;

            while (devam)
            {
                Console.Write("Tercih? : ");
                tercih = Console.ReadLine();
                if(album.ContainsKey(tercih)  || tercih == "0") // 0 değeri dict. key'de olmamalı!!  //albümde(kütüphanede) tercih edilen var mı bak dedik.
                {
                   devam = false;
                }
                else
                {
                    Console.Clear();
                    GosterListe();
                    Console.WriteLine("Geçersiz tercih");
                }
            }  
            return tercih;  
        }

        private static string TercihPanel()
        {
            string tercih ="";
            bool devam = true;

            while (devam)
            {
                Console.Write("Tercih? : ");
                tercih = Console.ReadLine();
                if(tercih == "1" || tercih == "2" || tercih == "0")   // Paneldeki butonlar Çal(1) Dur(2)
                {
                   devam = false;
                }
                else
                {
                    Console.Clear();
                    GosterPanel();
                    Console.WriteLine("Geçersiz tercih");
                }
            } 
            return tercih;             
        }

        private static void AlbumOlustur()
        {
            album.Add("1", "Parça 1");
            album.Add("2", "Parça 3");
            album.Add("3", "Parça 3");
            album.Add("4", "Parça 4");
            Console.WriteLine("Album Oluşturuldu.");
        }

        private static void GosterListe()
        {
             System.Console.WriteLine("ALBUM");
           foreach (var p in album)
            {
                Console.WriteLine($"Parça No : {p.Key} - Parça Adı : {p.Value} "); 
            }
             System.Console.WriteLine("------------");
             System.Console.WriteLine("ÇIKIŞ (0)");
        }

        private static void GosterPanel()
        {
             Console.WriteLine($"Çalan parça : {calanParca}");
             Console.WriteLine(" ÇAL(1)      |     DUR(2)    |     Çıkış(0)  ");
        }

        private static void DurCalGecis()
        {
            durum = true;
            GecmiseEkle();
            Console.Clear();
        }

        private static void CalDurGecis()
        {
            durum = false;
            Console.Clear();
        }

        private static void GecmiseEkle()
        {
          gecmis.Push(calanParca);
        }
     }
}
