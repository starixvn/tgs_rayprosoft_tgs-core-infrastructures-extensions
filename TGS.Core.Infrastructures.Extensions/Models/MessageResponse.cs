namespace TGS.Core.Infrastructures.Extensions.Models;

public record MessageResponse
{
    public MessageResponse()
    {
        Valid = false;
        Message = string.Empty;
        Errors = new string[]
        {
        };
    }

    public bool Valid { get; init; }

    public string Message { get; init; } = default!;

    public string[] Errors { get; init; }
}