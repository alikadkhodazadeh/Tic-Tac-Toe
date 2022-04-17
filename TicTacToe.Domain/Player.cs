namespace TicTacToe.Domain;

public class Player
{
    public string NickName { get; set; }
    public MarkerType MarkerType { get; set; }

    public override string ToString()
    {
        return NickName;
    }
}
