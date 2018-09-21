using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017_Day1.Tests
{
    [TestClass]
    public class SolverTests
    {
        [TestMethod]
        public void Test1()
        {
            // 1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.

            // Arrange / Act
            var result = Solver.Solve("1122");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Test2()
        {
            // 1111 produces 4 because each digit (all 1) matches the next.

            // Arrange / Act
            var result = Solver.Solve("1111");

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Test3()
        {
            // 1234 produces 0 because no digit matches the next.

            // Arrange / Act
            var result = Solver.Solve("1234");

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test4()
        {
            // 91212129 produces 9 because the only digit that matches the next one is the last digit, 9.

            // Arrange / Act
            var result = Solver.Solve("91212129");

            // Assert
            Assert.AreEqual(9, result);
        }
    }
}