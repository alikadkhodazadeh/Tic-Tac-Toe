namespace TicTacToe.Domain;

public class Position
{
    public Position(PositionType type)
    {
        State = PositionState.Empty;
        Type = type;
    }

    public PositionState State { get; private set; }
    public PositionType Type { get; }

    public OperationResult Mark(MarkerType markerType)
    {
        if (State is PositionState.Empty)
        {
            switch (markerType)
            {
                case MarkerType.X:
                    State = PositionState.X;
                    break;
                case MarkerType.O:
                    State = PositionState.O;
                    break;
            }
            return OperationResult.BuildSuccess();
        }
        return OperationResult.BuildFailure(ErrorType.PositionStateIsNotEmpty);
    }
}
