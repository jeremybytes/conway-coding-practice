using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conway.Library.MSTest
{
    [TestClass]
    public class LifeRulesTests
    {
        //Any live cell with fewer than two live neighbors dies.
        //Any live cell with two or three live neighbors lives.
        //Any live cell with more than three live neighbors dies.
        //Any dead cell with exactly three live neighbors becomes a live cell.

        [TestMethod]
        public void LiveCell_LessThanTwoLiveNeighbors0_Dies()
        {
            // Any live cell with fewer than two live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 0;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_LessThanTwoLiveNeighbors1_Dies()
        {
            // Any live cell with fewer than two live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 1;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_TwoOrThreeLiveNeighbors2_Lives()
        {
            // Any live cell with two or three live neighbors lives.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 2;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Alive, result);
        }

        [TestMethod]
        public void LiveCell_TwoOrThreeLiveNeighbors3_Lives()
        {
            // Any live cell with two or three live neighbors lives.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 3;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Alive, result);
        }

        [TestMethod]
        public void LiveCell_MoreThanThreeNeighbors4_Dies()
        {
            // Any live cell with more than three live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 4;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_MoreThanThreeNeighbors5_Dies()
        {
            // Any live cell with more than three live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 5;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_MoreThanThreeNeighbors6_Dies()
        {
            // Any live cell with more than three live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 6;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_MoreThanThreeNeighbors7_Dies()
        {
            // Any live cell with more than three live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 7;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void LiveCell_MoreThanThreeNeighbors8_Dies()
        {
            // Any live cell with more than three live neighbors dies.
            // Arrange
            CellState currentState = CellState.Alive;
            int liveNeighbors = 8;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_ExactlyThreeLiveNeighbors3_Lives()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 3;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Alive, result);
        }

        [TestMethod]
        public void DeadCell_LessThanThreeLiveNeighbors0_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 0;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_LessThanThreeLiveNeighbors1_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 1;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_LessThanThreeLiveNeighbors2_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 2;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_MoreThanThreeLiveNeighbors4_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 4;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_MoreThanThreeLiveNeighbors5_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 5;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_MoreThanThreeLiveNeighbors6_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 6;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_MoreThanThreeLiveNeighbors7_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 7;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

        [TestMethod]
        public void DeadCell_MoreThanThreeLiveNeighbors8_Dies()
        {
            // Any dead cell with exactly three live neighbors becomes a live cell.
            // Arrange
            CellState currentState = CellState.Dead;
            int liveNeighbors = 8;

            // Act
            CellState result = LifeRules.GetNewState(currentState, liveNeighbors);

            // Assert
            Assert.AreEqual(CellState.Dead, result);
        }

    }
}
