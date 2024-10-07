﻿using CodeWars1.Factory;

namespace CodeWars1.Katas
{
    public class PrimeNumber : IKata
    {
        public string GetKataName()
        {
            return "PrimeNumber";
        }

        public bool Execute(string n)
        {
            int value;
            if (int.TryParse(n, out value))
            {

            }
            if (value <= 0)
            {
                return false;
            }

            bool sudy;
            int mezi;

            for (int i = 0; i < value / 2; i++)
            {
                sudy = value % 2 == 0;

                if (sudy == true)
                {
                    mezi = value / 2;
                }
                else if (value % (value / 2 - i) != 0)
                {
                    mezi = value / (value / 2) - i;
                }
                else
                {
                    Console.WriteLine("fpici");
                    return false;
                }
                Console.WriteLine("good" + mezi);
            }

            return true;
        }
    }
}
