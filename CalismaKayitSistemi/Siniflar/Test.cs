namespace CalismaKayitSistemi.Siniflar
{
    class Test : object 
    {  //Burada override edebileceğimiz şeyler tmelden gelen objectler.ToString gibi.

           public override string ToString()
        {
            string s = "Yeni Tanım";
            return s + base.ToString();
        }

        
    }

}