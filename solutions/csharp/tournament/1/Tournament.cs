using System.Text;

internal class AggregatedStats(string teamName) : IComparable<AggregatedStats>
{
    public string TeamName { get; } = teamName;

    public int Wins
    {
        get;
        set
        {
            field = value;
            UpdateStats();
        }
    }

    public int Draws
    {
        get;
        set
        {
            field = value;
            UpdateStats();
        }
    }

    public int Losses
    {
        get;
        set
        {
            field = value;
            UpdateStats();
        }
    }

    public int Played { get; private set; }
    public int Points { get; private set; }

    private void UpdateStats()
    {
        Played = Wins + Losses + Draws;
        Points = Wins * 3 + Draws;
    }

    public int CompareTo(AggregatedStats? other) {
        if (other is null)
        {
            throw new Exception();
        }

        if (Points == other.Points)
        {
            return string.Compare(TeamName, other.TeamName, StringComparison.Ordinal);
        }
        
        return other.Points.CompareTo(Points);
    }
    public override string ToString() => $"{TeamName,-30} | {Played,2} | {Wins,2} | {Draws,2} | {Losses,2} | {Points,2}";
}

public static class Tournament
{

    private static IEnumerable<char> ReadStream(Stream inStream)
    {
        using var reader = new StreamReader(inStream);

        while (true)
        {
            var c = reader.Read();
            if (c < 0)
            {
                yield break;
            }

            yield return (char)c;
        }
    }

    public static void Tally(Stream inStream, Stream outStream)
    {
        var writer = new StreamWriter(outStream);
        writer.Write("Team                           | MP |  W |  D |  L |  P");

        if (inStream.Length <= 0)
        {
            writer.Flush();
            return;
        }

        writer.Write("\n");

        var sb = new StringBuilder();
        var line = new List<string>();
        var lines = new List<List<string>>();

        foreach (var c in ReadStream(inStream))
        {

            switch (c)
            {
                case ';':
                    line.Add(sb.ToString());
                    sb.Clear();
                    continue;
                case '\n':
                    line.Add(sb.ToString());
                    lines.Add(line);
                    line = [];
                    sb.Clear();
                    continue;
                default:
                    sb.Append(c);
                    break;
            }

        }
        line.Add(sb.ToString());
        lines.Add(line);

        var stats = BuildTeamStats(lines).Select(kv => kv.Value);

        writer.Write(string.Join("\n", stats.Order()));

        writer.Flush();
    }

    private static Dictionary<string, AggregatedStats> BuildTeamStats(List<List<string>> stats)
    {
        var teamStats = new Dictionary<string, AggregatedStats>();

        foreach (var line in stats)
        {
            var team1 = line[0];
            var team2 = line[1];
            var result = line[2];
            
            if (!teamStats.ContainsKey(team1))
            {
                teamStats.Add(team1, new AggregatedStats(team1));
            }

            if (!teamStats.ContainsKey(team2))
            {
                teamStats.Add(team2, new AggregatedStats(team2));
            }

            if (result == "draw")
            {
                teamStats[team1].Draws += 1;
                teamStats[team2].Draws += 1;
            }

            var updateOrder = result switch
            {
                "win" => new [] { team1, team2},
                "loss" => new [] { team2, team1},
                _ => Array.Empty<string>()
            };

            if (updateOrder.Length <= 0)
            {
                continue;
            }
            
            teamStats[updateOrder[0]].Wins += 1;
            teamStats[updateOrder[1]].Losses += 1;
        }

        return teamStats;
    }
}