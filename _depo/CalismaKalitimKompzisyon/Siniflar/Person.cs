namespace CalismaKalitimKompozisyon.Siniflar
{
    class Person 
    {
        private Animal a; //field
        private Swimmable s; //
        public Person(Animal a, Swimmable s)   //ctor //orda bir method var ona sahip olmak istiyorum için burası.
        {
            this.a= a;
            this.s = s;   //bu class(Person) içinde s. diye kullanabilirim artık.
        }






    }

}