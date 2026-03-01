static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var segments = new List<string>();

        if (id != null)
        {
            segments.Add($"[{id}]");
        }
        
        segments.Add(name);

        segments.Add(department != null ? department.ToUpper() : "OWNER");

        return string.Join(" - ", segments);
    }
}
