using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många timmar ska du hyra bilen för ? OBS: Svara med helt antal timmar. Max antal timmar är 11 timmar");
        int timmar = Convert.ToInt32(Console.ReadLine());

        int summa = timmar * 80;

        if (summa <= 950)
        {
            Console.WriteLine($"Du kommer att betala {summa} kr för {timmar} timmar");
        }
    }
}