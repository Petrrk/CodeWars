using CodeWars1.Factory.Entities;

namespace CodeWars1.Factory
{
    public interface IKata
    {
        KataName GetKataName();

        CompletionStatus CompletionStatus { get; }

        OutputType OutputType { get; }

        string Execute(string input);
    }
}
