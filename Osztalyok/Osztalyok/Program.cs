namespace Osztalyok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Osztályok, objektumok");

            //Procedurális szoftverfejlesztés: eljárások, függvények segítségével oldunk meg egy feladatot
            //Objektum-orientált szoftverfejlesztés: A megoldandó problémát osztályok és objektumok segítségével oldjuk meg.

            //Objektum: tartalmazhat adatokat valamiről és tartalmazhat függvényeket is (metódus)
            //Az oop szemlélet bizonyult eddig a legalkalmasabbnak arra, hogy valós világbeli dolgokat le lehessen írni.
            //Osztály: az objektum "terve", leírja az adatokat és a metódusokat
            //Példány: az osztály alapján gyártott objektum

            //Egységbe zárás (encapsulation): Az osztály elrejt minden olyan dolgot, ami nem tartozik a külvilágra. Az osztály adatait csak metódusokon keresztül lehessen elérni.

            //A Szemely osztály példányosítása
            Szemely ubul=new Szemely("Kiss","Ubul",1991);
            Szemely elek = new Szemely("Nagy", "Elek", 2001);

            //ubul.vezeteknev = "Kiss";
            //ubul.keresztnev = "Ubul";
            //ubul.szuletesiev = 1991;

            //Console.WriteLine(ubul.vezeteknev);

            //ubul.SetNev("Kósa","György");
            //ubul.SetSzuletesiEv(2001);

            Console.WriteLine(ubul.GetNev());
            Console.WriteLine(ubul.GetSzuletesiev());

            Ember ember = new Ember {
                Vezeteknev="Kelemen",
                Keresztnev="László",
                SzuletesiEv=2004
            };

            Ember masikEmber = new Ember("Vágó", "Géza", 1986);

            Console.WriteLine(ember.GetEletkor());
            Console.WriteLine(masikEmber.GetEletkor());

        }
    }
}
