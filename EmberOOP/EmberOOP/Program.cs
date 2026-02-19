namespace EmberOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ember OOP");

            List<Dolgozo> dolgozok=new List<Dolgozo>();
            List<Ember> emberek=new List<Ember>();

            dolgozok.Add(new Dolgozo("Endre", 178, 29, "Csőd Kft"));
            emberek.Add(new Dolgozo("Endre", 178, 29, "Csőd Kft"));

            Nyugdijas nyugdijas = new Nyugdijas("Géza", 169, 71, 45);
            Sportolo sportolo = new Sportolo("Éva", 170, 58, "tenisz");

            //dolgozok.Add(nyugdijas);
            emberek.Add(nyugdijas);
            emberek.Add(sportolo);

            foreach (var i in emberek)
            {
                Console.WriteLine($"{i.Nev},{i.Eletkor},{i.Magassag}");
                if (i.GetType()==typeof(Dolgozo))
                {
                    //kasztolás
                    Dolgozo dolgozo = (Dolgozo)i;
                    Console.WriteLine($"Dolgozó, munkahelye:{dolgozo.Munkahely}");
                }
                if (i.GetType() == typeof(Sportolo)) {
                    Sportolo Sportolo=i as Sportolo;
                    Console.WriteLine($"Sportoló, sportága:{Sportolo.Sportag}");
                }
            }



        }
    }
}
