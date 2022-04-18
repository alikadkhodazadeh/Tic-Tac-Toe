namespace TicTacToe.Domain;

public class Game
{
    public Game(Player playerX, Player playerO)
    {
        Players = new List<Player> { playerX, playerO };

        PlayerX = playerX;
        PlayerO = playerO;

        Board = new Board();
        Moves = new List<Move>();
    }

    public Player PlayerX { get; }
    public Player PlayerO { get; }

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

    public Player GetNextTurn()
    {
        if (Moves.Any())
        {
            var lastPlayer = Moves.Last().Player;
            if (PlayerX == lastPlayer)
                return PlayerO;
            else
                return PlayerX;
        }
        else
            return PlayerX;
    }

    public GameResult GetWinner()
    {
        if (Moves.Count < 5)
            return GameResult.Play;

        var xWins = Board.HasAllRow(PositionState.X);
        if (xWins)
            return GameResult.XWin;

        var oWins = Board.HasAllRow(PositionState.O);
        if (oWins)
            return GameResult.OWin;

        if((xWins is false && oWins is false) && Board.Positions.Any(p=>p.State == PositionState.Empty))
            return GameResult.Play;

        return GameResult.Draw;
    }
}
