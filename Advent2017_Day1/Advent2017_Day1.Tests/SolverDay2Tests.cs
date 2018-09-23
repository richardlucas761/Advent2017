using System.Text;
using Advent2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent2017_Day1.Tests
{
    [TestClass]
    public class SolverDay2Tests
    {
        [TestMethod]
        public void SolverDay2Test1()
        {
            /*
             
            Given the following spreadsheet:

            5 1 9 5
            7 5 3
            2 4 6 8

            The first row's largest and smallest values are 9 and 1, and their difference is 8.
                The second row's largest and smallest values are 7 and 3, and their difference is 4.
                The third row's difference is 6.

                In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.
                
           */

            // Arrange
            var spreadsheet = new StringBuilder();
            spreadsheet.AppendLine("5 1 9 5");
            spreadsheet.AppendLine("7 5 3");
            spreadsheet.AppendLine("2 4 6 8");

            // Act
            var result = Solver.SolveDay2(spreadsheet.ToString());

            // Assert
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void RowCheckSumTest1()
        {
            // The first row's largest and smallest values are 9 and 1, and their difference is 8.

            // Arrange
            const string line = "5 1 9 5";

            // Act
            var result = Solver.CheckSumForRow(line);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void RowCheckSumTest2()
        {
            // The second row's largest and smallest values are 7 and 3, and their difference is 4.

            // Arrange
            const string line = "7 5 3";

            // Act
            var result = Solver.CheckSumForRow(line);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RowCheckSumTest3()
        {
            // The third row's difference is 6.

            // Arrange
            const string line = "2 4 6 8";

            // Act
            var result = Solver.CheckSumForRow(line);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void RowCheckSumTestEmptyString()
        {
            // Arrange / Act
            var result = Solver.CheckSumForRow(string.Empty);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RowCheckSumTestNull()
        {
            // Arrange / Act
            var result = Solver.CheckSumForRow(null);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RowCheckSumTestWhiteSpace()
        {
            // Arrange / Act
            var result = Solver.CheckSumForRow(" ");

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}