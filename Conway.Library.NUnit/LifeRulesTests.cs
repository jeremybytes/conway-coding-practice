using NUnit.Framework;

namespace Conway.Library.NUnit
{
    [TestFixture]
    public class LifeRulesTests
    {
        [TestCase(0)]
        [TestCase(1)]
        public void LiveCell_LessThanTwoLiveNeighbors_Dies(int liveNeighbors)
        {
            // Any live cell with fewer than two live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestCase(2)]
        [TestCase(3)]
        public void LiveCell_TwoOrThreeLiveNeighbors_Lives(int liveNeighbors)
        {
            // Any live cell with two or three live neighbors lives.
            // Arrange
            CellState currentState = CellState.Alive;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Alive, result);
        }

        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        public void LiveCell_MoreThanThreeLiveNeighbors_Dies(int liveNeighbors)
        {
            // Any live cell with more than 3 neighbors dies (over-crowding)
            // Arrange
            CellState currentCell = CellState.Alive;

            // Act
            currentCell = LifeRules.GetNewState(currentCell, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, currentCell);
        }

        [TestCase(3)]
        public void DeadCell_ExactlyThreeLiveNeighbors_Lives(int liveNeighbors)
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Alive, result);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void DeadCell_LessThanThreeLiveNeighbors_Dies(int liveNeighbors)
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        public void DeadCell_MoreThanThreeLiveNeighbors_Dies(int liveNeighbors)
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }
    }
}
