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
            //ToLower muudab kõik tähed väikseks
            //ja siis leiab alati ülesse.
            string mark = Console.ReadLine().ToLower();

            if (mark == "bmw")
            {
                Console.WriteLine("See on BMW");
            }
            else if (mark == "audi")
            {
                Console.WriteLine("See on Audi");
            }
            else if (mark == "porsche")
            {
                Console.WriteLine("See on Porsche");
            }
            else if (mark == "skoda")
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
