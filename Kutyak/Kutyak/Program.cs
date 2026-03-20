namespace Kutyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutyák");

            List<Kutya> kutyak= new List<Kutya>();
            List<Kutyanev> kutyanevek= new List<Kutyanev>();
            List<Kutyafajta> kutyafajtak= new List<Kutyafajta>();

            try
            {
                kutyak = Betolto.BetoltKutya("kutyak.csv", ';');
                kutyanevek = Betolto.BetoltKutyanev("kutyanevek.csv", ';');
                kutyafajtak = Betolto.BetoltKutyafajta("kutyafajtak.csv", ';');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"{kutyak.Count},{kutyanevek.Count},{kutyafajtak.Count}");

            //Listák összeolvasztása
            var kutyak_kutyanevek = kutyak.Join(kutyanevek,
                k => k.NevId,
                kn => kn.Id,
                (k, kn) => new {k.Id,k.NevId,k.FajtaId,k.Eletkor,k.UtolsoEllenorzes,kn.KutyaNev }
             );

            var kutyak_kutyanevek_kutyafajtak = kutyak_kutyanevek.Join(kutyafajtak,
                kkn => kkn.FajtaId,
                kf => kf.Id,
                (kkn, kf) => new {
                    kkn.Id,
                    kkn.NevId,
                    kkn.FajtaId,
                    kkn.Eletkor,
                    kkn.UtolsoEllenorzes,
                    kkn.KutyaNev,
                    kf.FajtaNev,
                    kf.FajtaEredetiNev }
             );

            //Innentől kezdve a korábban tanult eszközökkel kiszűrhetőek a kívánt adatok
            //DE! FindAll helyett Select-et kell használni
            //Legidősebb kutya




        }
    }
}
