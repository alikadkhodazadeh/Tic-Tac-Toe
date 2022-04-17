namespace TicTacToe.Domain.Constants;

public static class InitializePositions
{
    public static List<Position> Initializing()
    {
        return new List<Position>()
        {
            new Position() { State = PositionState.Empty, Type = PositionType.One },
            new Position() { State = PositionState.Empty, Type = PositionType.Two },
            new Position() { State = PositionState.Empty, Type = PositionType.Three },
            new Position() { State = PositionState.Empty, Type = PositionType.Four },
            new Position() { State = PositionState.Empty, Type = PositionType.Five },
            new Position() { State = PositionState.Empty, Type = PositionType.Six },
            new Position() { State = PositionState.Empty, Type = PositionType.Seven },
            new Position() { State = PositionState.Empty, Type = PositionType.Eight },
            new Position() { State = PositionState.Empty, Type = PositionType.Nine },
        };
    }
}
