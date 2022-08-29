internal class Program
{
    private static void Main(string[] args)
    {
        // type safety - tip guvenlifgi
        // Do not repeat yourself
        string categoryTag = "Category";
        int studentTall = 32000;
        double renteProocent = 1.45;
        bool erDuLogIn = true;
        double dollarDun = 7.55;
        double dollarBugun = 7.55;

        if (dollarDun>dollarBugun)
        {
            Console.WriteLine("Azalis butonu");
        }
        else if (dollarDun<dollarBugun)
        {
            Console.WriteLine("Artis butonu");
        }
        else
        {
            Console.WriteLine("Degismedi");
        }

        if (erDuLogIn == true)

           
        {
            Console.WriteLine(" Users setnings button");
        }
        else
        {
            Console.WriteLine("Login button");
        }
        Console.WriteLine("categoryTag");
    }
}