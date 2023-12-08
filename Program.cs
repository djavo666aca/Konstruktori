namespace Konstruktori
{
    internal class Program
    {
        string status;

        Program()
        {
            status = "Aktivan";
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.status);

            Program p2 = new Program();
            Console.WriteLine(p2.status);

            p2.status = "Iskljuceno";
            Console.WriteLine(p2.status);
        }
    }
}
