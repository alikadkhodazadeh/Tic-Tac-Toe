namespace TicTacToe.Domain;

public class Game
{
    public Game(Player playerX, Player playerO)
    {
        Players = new List<Player> { playerX, playerO };
        Board = new Board();
        Moves = new List<Move>();
    }

    public Board Board { get; set; }
    public List<Player> Players { get; set; }
    public List<Move> Moves { get; set; }

    public void AddMove(Move move)
    {
        Moves.Add(move);
    }

    public Player GetWinner()
    {
        // ---
        return null;
    }
}
