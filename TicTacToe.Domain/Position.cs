namespace TicTacToe.Domain;

public class Position
{
    public Position(PositionType type)
    {
        State = PositionState.Empty;
        Type = type;
    }

    public PositionState State { get; set; }
    public PositionType Type { get; set; }
}
