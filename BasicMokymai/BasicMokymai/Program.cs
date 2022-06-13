namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            

            Console.WriteLine("------------------------------------");
            Console.WriteLine("išvedimas" + "vienoje " + "eilutėje"); // konkatinacija
            Console.WriteLine("{0} {1} {2}", "isvedimas", "vienoje", "eiluteje"); // kompozicija
            Console.WriteLine($"{"isvedimas"} {"vienoje"} {"eiluteje"}"); // interpoliacija

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"tekstas {Environment.NewLine} idedamas"); // perkelia teksta i nauja eilute nepriklausomai nuo OS
            Console.ReadKey();
        }
    }
}