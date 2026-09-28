namespace IfElseAutod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else 
            //kirjuta automark
            //valikus on BMW, Audi, Porsche ja Skoda
            //Kui valitakse Škoda, siis seal sees on uuesti küsimus, et 
            //mis mudelit soovid valida. Mudeli valikus Kodiaq ja Octavia

            Console.WriteLine("Sisesta automark");
            //siin sisestad teksti konsooli
            string mark = Console.ReadLine();

            if (mark == "BMW")
            {
                Console.WriteLine("See on BMW");
            }
            else if (mark == "Audi")
            {
                Console.WriteLine("See on Audi");
            }
            else if (mark == "Porsche")
            {
                Console.WriteLine("See on Porsche");
            }
            else if (mark == "Skoda")
            {
                Console.WriteLine("See on Skoda");
                Console.WriteLine("Nüüd vali mudel, kas Kodiaq või Octavia");
                string mudel = Console.ReadLine();
                if (mudel == "Kodiaq")
                {
                    Console.WriteLine("Valisid Kodiaqi");
                }
                else if (mudel == "Octavia")
                {
                    Console.WriteLine("Valisid Octavia");
                }
                else
                {
                    Console.WriteLine("Ei valinud midagi");
                }
            }
            else
            {
                Console.WriteLine("Ei valinud automarki");
            }
        }
    }
}
