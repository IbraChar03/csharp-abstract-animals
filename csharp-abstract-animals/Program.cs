namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane();
            cane.Mangia();
            cane.Verso();

            Aquila aquila = new Aquila();
            aquila.Mangia();
            aquila.Verso();

            Delfino delfino = new Delfino();
            delfino.Mangia();
            delfino.Verso();

            Passerotto passerotto = new Passerotto();
            passerotto.Mangia();
            passerotto.Verso();
            delfino.FaiNuotare(delfino);
        
        }
    }
}