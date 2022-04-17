using TicTacToe.Domain.Constants;

namespace TicTacToe.Domain;

public class Board
{
    public Board()
    {
        ResetPositions();
    }

    public List<Position> Positions { get; set; }

    public void ResetPositions()
    {
        Positions = InitializePositions.Initializing();
    }
}