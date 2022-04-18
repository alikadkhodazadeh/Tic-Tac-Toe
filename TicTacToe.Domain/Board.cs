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

    public bool HasAllRow(PositionState state)
    {
        // Horizontal
        var r1 = Positions[0].State == state && Positions[1].State == state && Positions[2].State == state;
        var r2 = Positions[3].State == state && Positions[4].State == state && Positions[5].State == state;
        var r3 = Positions[6].State == state && Positions[7].State == state && Positions[8].State == state;

        // Vertical
        var r4 = Positions[0].State == state && Positions[3].State == state && Positions[6].State == state;
        var r5 = Positions[3].State == state && Positions[4].State == state && Positions[7].State == state;
        var r6 = Positions[6].State == state && Positions[5].State == state && Positions[8].State == state;

        // Diagonal
        var r7 = Positions[0].State == state && Positions[4].State == state && Positions[8].State == state;
        var r8 = Positions[6].State == state && Positions[4].State == state && Positions[2].State == state;

        var result = r1 || r2 || r3 || r4 || r5 || r6 || r7 || r8;

        return result;
    }
}