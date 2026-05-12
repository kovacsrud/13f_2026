using System.Timers;

namespace Idozitok
{
    internal class Program
    {
        static int szamlalo = 0;
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Callback;
            timer.Start();
            Console.ReadKey();
        }

        private static void Callback(object sender, ElapsedEventArgs e){
            Console.WriteLine($"{szamlalo}-{DateTime.Now.Second}");
            szamlalo++;
        }
    }
}
