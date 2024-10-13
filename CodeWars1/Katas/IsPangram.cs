using CodeWars1.Factory;
using CodeWars1.Factory.Entities;

namespace CodeWars1.Katas
{
    public class IsPangram : IKata
    {
        public OutputType OutputType => OutputType.Bool;

        public CompletionStatus CompletionStatus => CompletionStatus.Done;

        public KataName GetKataName()
        {
            return KataName.IsPangram;
        }

        //sort by least used;
        //other potential improvement is to manipulate the initial input to have unique chars

        public string Execute(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; 

            foreach (var character in alphabet)
            {
                if (!input.ToLower().Contains(character))
                {
                    return "False";
                }
            }
            return "True";
        }
     }
}
