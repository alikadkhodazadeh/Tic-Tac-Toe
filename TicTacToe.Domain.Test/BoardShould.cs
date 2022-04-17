using Xunit;

namespace TicTacToe.Domain.Test;

public class BoardShould
{
    [Fact]
    public void Have_Nine_Positions()
    {
        // Arrange
        var board = new Board();

        // Act
        var positions = board.Positions;

        // Assert
        Assert.True(positions.Count == 9);
    }
}
