namespace TicTacToe.Domain;

public class Game
{
    public Game(Player playerX, Player playerO)
    {
        Players = new List<Player> { playerX, playerO };
        Board = new Board();
        Moves = new List<Move>();
    }

    public Board Board { get; private set; }
    public List<Player> Players { get; private set; }
    public List<Move> Moves { get; private set; }

    public OperationResult AddMove(Move move)
    {
        if (Moves.Count == 0)
            return OperationResult.BuildFailure("No moves left!");

        var lastMove = Moves.Last();
        if (lastMove.Player.NickName == move.Player.NickName)
            return OperationResult.BuildFailure($"Not {move.Player} turn!");

        var result = Board.Fork(move.Position.Type, move.Player.MarkerType);
        if (result.Success)
            Moves.Add(move);

        return result;
    }

    public Player GetWinner()
    {
        // ---
        return null;
    }
}
