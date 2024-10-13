using System.ComponentModel;

namespace CodeWars1.Factory.Entities
{
    public enum CompletionStatus
    {
        [Description("still in progress")]
        InProgress,
        [Description("done and dusted*")]
        Done,
        [Description("done and dusted")]
        DoneAndDusted,
        [Description("don't talk about this one")]
        Forfeited,
    }
}
