namespace TicTacToe.Domain.Constants;

public static class InitializePositions
{
    public static List<Position> Initializing()
    {
        return new List<Position>()
        {
            new Position() { State = PositionState.Empty, Type = PositionTypre.One },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Two },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Three },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Four },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Five },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Six },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Seven },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Eight },
            new Position() { State = PositionState.Empty, Type = PositionTypre.Nine },
        };
    }
}
