public class DndCharacter
{
    public int Strength { get; init;  }
    public int Dexterity { get; init;  }
    public int Constitution { get; init;  }
    public int Intelligence { get; init;  }
    public int Wisdom { get; init;  }
    public int Charisma { get; init;  }
    public int Hitpoints { get; init;  }

    public static int Modifier(int score) => (int)Math.Floor(((double)score - 10) / 2);

    public static int Ability() => Roll.D(4, 6)
        .OrderDescending()
        .Take(3)
        .Sum();

    public static DndCharacter Generate() {
        var constitution = Ability();
        
        return new DndCharacter
        {
            Strength = Ability(),
            Dexterity = Ability(),
            Constitution = constitution,
            Intelligence = Ability(),
            Wisdom = Ability(),
            Charisma = Ability(),
            Hitpoints = 10 + Modifier(constitution),
        };
    }

}

internal static class Roll
{
    private static readonly Random Rng = new();

    private static int D(int die) => Rng.Next(1, die + 1);

    public static int[] D(int n, int die) => Enumerable.Range(0, n)
        .Select(_ => D(die))
        .ToArray();
}
