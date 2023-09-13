namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, AnimalWord!");
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
                Console.WriteLine();
                animale.CosaMangi();
                Console.WriteLine();
                animale.Verso();
                Console.WriteLine();
                animale.Dormi();
                Console.WriteLine() ;
            }
            aquila.Vola();
            delfino.Nuota();
            passerotto.Vola();
            cane.Cammino();
            cane.Nuota();

        }
    }
}