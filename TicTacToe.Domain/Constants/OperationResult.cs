namespace TicTacToe.Domain;

public class OperationResult
{
    public bool Success { get; private set; }
    public string ErrorMessage { get; private set; }
    public ErrorType ErrorType { get; private set; }

    public static OperationResult BuildSuccess() => new OperationResult { Success = true };
    public static OperationResult BuildFailure() => new OperationResult { Success = false, ErrorType = ErrorType.Unknown };
    public static OperationResult BuildFailure(ErrorType errorType) => new OperationResult { Success = false, ErrorType = errorType };
    public static OperationResult BuildFailure(string errorMessage) => new OperationResult { Success = false, ErrorMessage = errorMessage };
}
