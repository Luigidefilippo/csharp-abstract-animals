namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, AnimalWord! Presentatevi");
            Delfino delfino = new Delfino();
            Cane cane = new Cane(); 
            Aquila aquila = new Aquila();
            Passerotto passerotto = new Passerotto();

            List<Animale>animali = new List<Animale>();
            animali.Add(cane);
            animali.Add(aquila);
            animali.Add(passerotto);
            animali.Add(delfino);

            foreach (Animale animale in animali)
            {
                animale.GetName();
                Console.WriteLine("------------------------------------------------");
                animale.CosaMangi();
                Console.WriteLine("------------------------------------------------");
                animale.Verso();
                Console.WriteLine("------------------------------------------------");
                animale.Dormi();
                Console.WriteLine("------------------------------------------------") ;
            }
            Console.WriteLine("Cosa sappiamo fare ");
            Console.WriteLine();
            aquila.Vola();
            Console.WriteLine();
            delfino.Nuota();
            Console.WriteLine();
            passerotto.Vola();
            Console.WriteLine();
            cane.Cammino();
            cane.Nuota();

        }
    }
}