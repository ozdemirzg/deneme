namespace CalismaKalitimKompozisyon.Siniflar
{
    class Dog 
    {
      private Animal _a;  //field tanımladık.
      //  public Animal __a { get; set; }   //böyle prop ile de böyle yazabilirdik.Ama public burada işimize gelmiyor.field daha mantıklı
      public Dog(Animal a)  //ctor ile açtık bunu.prop yada field(private) ile de sahiplik ilişkisi kurman lazım classta.!Bunlara composition için yapıyoruz.
      {
          _a = a; //'this.a = a' diyebilirdin. _ kullanmak istemezsen.Ama _ bize private diyor.
      }
    }

}