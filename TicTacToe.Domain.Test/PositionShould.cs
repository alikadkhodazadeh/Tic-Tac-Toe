using Xunit;

namespace TicTacToe.Domain.Test;

public class PositionShould
{
    [Fact]
    public void Can_Change_Empty_Position()
    {
        // Arrange
        var p1 = new Position(PositionType.One);
        var p2 = new Position(PositionType.One);

        // Act
        p1.Mark(MarkerType.X);
        p2.Mark(MarkerType.O);

        // Assert
        Assert.Equal(PositionState.X, p1.State);
        Assert.Equal(PositionState.O, p2.State);
    }

    [Fact]
    public void Not_Allow_Change_From_X_To_O()
    {
        // Arrange
        var position = new Position(PositionType.One);
        position.Mark(MarkerType.X);

        // Act
        position.Mark(MarkerType.O);

        // Assert
        Assert.NotEqual(PositionState.O, position.State);
    }
}