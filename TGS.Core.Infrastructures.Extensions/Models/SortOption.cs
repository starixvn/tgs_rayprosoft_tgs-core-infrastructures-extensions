namespace TGS.Core.Infrastructures.Extensions.Models;

public class SortOption(string? propertyName, bool isDescending)
{
    public string? PropertyName { get; init; } = propertyName;

    public bool IsDescending { get; init; } = isDescending;
}