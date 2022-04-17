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

    public void Mark(MarkerType markerType)
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
                default:
                    break;
            }
        }
    }
}
