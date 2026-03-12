[Flags]
enum Action
{
    Wink = 1,
    DoubleBlink = 1 << 1,
    CloseYourEyes = 1 << 2,
    Jump = 1 << 3,
    Reverse = 1 << 4
}

internal static class ActionExtensions
{
    public static string GetString(this Action action) => action switch
    {
        Action.Wink => "wink",
        Action.DoubleBlink => "double blink",
        Action.CloseYourEyes => "close your eyes",
        Action.Jump => "jump",
        _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
    };
}


public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var flags = (Action)commandValue;
        
        var actions = Enum.GetValues<Action>()
            .Where(action => action != Action.Reverse && flags.HasFlag(action))
            .Select(action => action.GetString())
            .ToArray();

        if (flags.HasFlag(Action.Reverse))
        {
            actions = actions.Reverse().ToArray();
        }

        return actions;
    }
}
