using Xunit;

namespace TicTacToe.Domain.Test;

public class PositionShould
{
    [Theory]
    [InlineData(PositionType.One, MarkerType.X, PositionState.X)]
    [InlineData(PositionType.One, MarkerType.O, PositionState.O)]
    [InlineData(PositionType.Two, MarkerType.X, PositionState.X)]
    [InlineData(PositionType.Three, MarkerType.O, PositionState.O)]
    public void Can_Change_Empty_Position(PositionType pt, MarkerType mt, PositionState ps)
    {
        // Arrange
        var position = new Position(pt);

        // Act
        position.Mark(mt);

        // Assert
        Assert.Equal(ps, position.State);
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