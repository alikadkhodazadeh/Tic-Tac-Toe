namespace TicTacToe.Domain.Constants;

public static class InitializePositions
{
    public static List<Position> Initializing()
    {
        return new List<Position>()
        {
            new Position(PositionType.One),
            new Position(PositionType.Two),
            new Position(PositionType.Three),
            new Position(PositionType.Four),
            new Position(PositionType.Five),
            new Position(PositionType.Six),
            new Position(PositionType.Seven),
            new Position(PositionType.Eight),
            new Position(PositionType.Nine),
        };
    }
}
