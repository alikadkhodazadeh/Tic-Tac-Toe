using TicTacToe.Domain.Constants;

namespace TicTacToe.Domain;

public class Board
{
    public Board()
    {
        ResetPositions();
    }

    public List<Position> Positions { get; private set; }

    public void ResetPositions()
    {
        Positions = InitializePositions.Initializing();
    }

    public OperationResult Fork(PositionType positionType, MarkerType markerType)
    {
        var selectedPos = Positions.Single(p=>p.Type == positionType);
        return selectedPos.Mark(markerType);
    }
}