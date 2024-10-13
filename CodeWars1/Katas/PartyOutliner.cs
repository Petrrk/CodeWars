using CodeWars1.Factory;
using CodeWars1.Factory.Entities;

namespace CodeWars1.Katas
{
    public class PartyOutliner : IKata
    {
        public OutputType OutputType => OutputType.Int;

        public CompletionStatus CompletionStatus => CompletionStatus.InProgress;

        public string Execute(string input)
        {
            throw new NotImplementedException(); 
        }

        public KataName GetKataName()
        {
            return KataName.PartyOutlier;
        }
    }
}
