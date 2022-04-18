namespace TicTacToe.Domain;

public enum ErrorType : byte
{
    Unknown = 0,
    PositionStateIsNotEmpty = 1,
    BoardPositionAlreadyForked = 2,
    MoveAlreadyExsited = 3,
    GameNotPlayerTrun = 4,
    GameNoMoreMovesLeft = 5
}