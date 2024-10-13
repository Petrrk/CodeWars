using CodeWars1.Factory.Entities;
using CodeWars1.Katas;

namespace CodeWars1.Factory
{
    public class KataFactory
    {
         public IKata? GetKata(KataName input)
        {
            switch (input)
            {
                case KataName.PrimeNumber:
                    return new PrimeNumber();
                case KataName.IsPangram:
                    return new IsPangram();
                case KataName.WeirdStringCase:
                    return new WeirdStringCase();
                case KataName.PartyOutlier:
                    return new PartyOutliner();
                default:
                    Console.WriteLine("Invalid Kata");
                    return null;
            }
        }
    }
}
