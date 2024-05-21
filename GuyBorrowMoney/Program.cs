namespace GuyBorrowMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy jacek = new Guy() { Cash = 50, Name = "Jacek" };

            Guy bartek = new Guy() { Cash = 100, Name = "Bartek" };

            while (true)
            {
                jacek.WriteMyInfo();
                bartek.WriteMyInfo();

                Console.Write("Podaj kwotę: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "")
                    return;

                if (int.TryParse(howMuch, out int result))
                {
                    Console.Write("Pieniądze ma przekazać: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Jacek")
                    {
                        bartek.ReceiveCash(jacek.GiveCash(result));
                    }
                    else if (whichGuy == "Bartek")
                    {
                        jacek.ReceiveCash(bartek.GiveCash(result));
                    }
                    else
                    {
                        Console.WriteLine("Wpisz 'Jacek' lub 'Bartek'.");
                    }
                }
                else
                {
                    Console.WriteLine("Wpisz kwotę (lub pusty wiersz, aby zakończyć).");
                }
            }


        }
    }
}
