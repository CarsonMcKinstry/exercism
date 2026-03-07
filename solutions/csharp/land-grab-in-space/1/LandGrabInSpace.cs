public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public int DistanceTo(Coord coord)
    {
        return Math.Abs(X - coord.X) + Math.Abs(Y - coord.Y);
    }
}

public struct Plot ( Coord topLeft, Coord topRight, Coord bottomRight, Coord bottomLeft )
{
    public Coord TopLeft { get; } = topLeft;
    public Coord TopRight { get; } = topRight;
    public Coord BottomRight { get; } = bottomRight;
    public Coord BottomLeft { get; } = bottomLeft;

    public int GetLongestSide()
    {
        var top = TopLeft.DistanceTo(TopRight);
        var right = TopRight.DistanceTo(BottomRight);
        var bottom = BottomRight.DistanceTo(BottomLeft);
        var left = BottomLeft.DistanceTo(TopLeft);

        var sides = new List<int>{top, right, bottom, left};
        
        sides.Sort((a, b) => b.CompareTo(a));

        return sides.First();
    }
}




public class ClaimsHandler
{
    private List<Plot> _stakedClaims = [];
    
    public void StakeClaim(Plot plot)
    {
        _stakedClaims.Add(plot);
    }

    public bool IsClaimStaked(Plot plot)
    {
        return _stakedClaims.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
        return _stakedClaims.Last().Equals(plot);
    }

    public Plot GetClaimWithLongestSide()
    {
        (Plot plot, int side)? claimWithLongestSide = null;

        foreach (var plot in _stakedClaims)
        {
            if (claimWithLongestSide == null)
            {
                claimWithLongestSide = (plot, plot.GetLongestSide());
                continue;
            }

            var longestSide = plot.GetLongestSide();

            if (longestSide > claimWithLongestSide.Value.side)
            {
                claimWithLongestSide = (plot, longestSide);
            }
        }
        
        return claimWithLongestSide!.Value.plot;
    }
}
