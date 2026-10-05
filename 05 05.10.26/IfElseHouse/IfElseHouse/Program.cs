namespace IfElseHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Teha neli if-i ja else -i kontrolli, kus
            //kontrollitakse majade ruutmeetrit.
            //Esimene kontroll on 0 - 40 ruutmeetri juures.
            //Teine kontroll 41 - 90 ruutmeetrit,
            //kolmas kontroll on 91 - 130 ruutmeetrit ja
            //neljas on suuremad, kui 131 ruutmeetrit.
            //Kui mingi suurus on tuvastatud, siis konsool näitab
            //teksti: Sinu maja suurus on(sisestatud suurus).

            Console.WriteLine("Sisesta maja suurus ruutmeetrites");

            int houseSize = int.Parse(Console.ReadLine());

            //esimene tingimus on alati if, teised on else if ja viimane on else
            if (houseSize >= 0 && houseSize <= 40)
            {
                Console.WriteLine($"Sinu maja suurus on {houseSize} m2.");
            }
            else if (houseSize >= 41 && houseSize <= 90)
            {
                Console.WriteLine($"Sinu maja suurus on {houseSize} m2.");
            }
            else if (houseSize >= 91 && houseSize <= 130)
            {
                Console.WriteLine($"Sinu maja suurus on {houseSize} m2.");
            }
            else if (houseSize >= 131)
            {
                Console.WriteLine($"Sinu maja suurus on {houseSize} m2.");
            }
            else
            {
                Console.WriteLine("Sisestatud väärtus ei ole kehtiv.");
            }
        }
    }
}
