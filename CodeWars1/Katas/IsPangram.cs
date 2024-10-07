using CodeWars1.Factory;

namespace CodeWars1.Katas
{
    public class IsPangram : IKata
    {
        public string GetKataName()
        {
            return "Pangram";
        }

        public bool Execute(string input)
        {
            string alphabet = "abcdefghijklmopqrstuvwxyz";

            foreach (var character in alphabet)
            {
                if (!input.ToLower().Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
     }
}
