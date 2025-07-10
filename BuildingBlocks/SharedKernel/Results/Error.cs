namespace BuildingBlocks.SharedKernel.Results;

public record Error(string Code, string Message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.Null", "Value is null.");
}
