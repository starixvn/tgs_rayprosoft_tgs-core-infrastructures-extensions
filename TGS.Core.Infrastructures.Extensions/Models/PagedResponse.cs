namespace TGS.Core.Infrastructures.Extensions.Models;

public record PagedResponse<T> : MessageResponse
{
    public PagedResponse()
    {
    }

    public PagedResponse(int count, T[] items)
    {
        TotalCount = count;
        Items = items;
    }

    public int TotalCount { get; init; }
    public T[] Items { get; init; }
}