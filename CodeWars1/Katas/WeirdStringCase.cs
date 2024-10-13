using CodeWars1.Factory;
using CodeWars1.Factory.Entities;

namespace CodeWars1.Katas
{
    public class WeirdStringCase : IKata
    {
        public OutputType OutputType => OutputType.String;

        public CompletionStatus CompletionStatus => CompletionStatus.DoneAndDusted;

        public KataName GetKataName()
        {
            return KataName.WeirdStringCase;
        }
        
        public string Execute(string input)
        {
            input = input.ToLower();
            char[] chars = input.ToCharArray();
            
            for (int i = 0; i < input.Length; i += 2)
            {
                while (chars[i] == 32)
                {
                    i++;
                }

                chars[i] = char.ToUpper(chars[i]);
            }

            return new string(chars);
        }       
    }
}
