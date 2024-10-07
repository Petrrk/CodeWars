using CodeWars1.Katas;

namespace CodeWars1.Factory
{
    public class KataFactory
    {
         public IKata? GetKata(string input)
        {
            switch (input)
            {
                case "PrimeNumber":
                    return new PrimeNumber();
                case "Pangram":
                    return new IsPangram();
                default:
                    Console.WriteLine("Invalid Kata");
                    return null;
            }

        }
    }
}
