using System.ComponentModel;

namespace CodeWars1.Factory.Entities
{
    public enum KataName
    {
        [Description("Is a Prime Number")]
        PrimeNumber,
        [Description("Detect Pangram")]
        IsPangram,
        [Description("WeIrD StRiNg CaSe")]
        WeirdStringCase,
        [Description("Find The Parity Outlier")]
        PartyOutlier,
    }
}
