using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass]
    public class ProgramTests
    {
       
        [TestMethod]
        public void Program_removes_white_space()
        {
            //Arrange
            string input = "This is a sample input ;;** ";

            //Act

            string output = Sorting.Program.ProcessInput(input);

            //Assert

            Assert.AreEqual(18, output.Length);

        }

        [TestMethod]
        public void Program_sorts_letters()
        {
            //Arrange
            string input = "azxccbb";

            //Act

            string output = Program.ProcessInput(input);

            //Assert

            Assert.AreEqual("abbccxz", output);

        }

        [TestMethod]
        public void Program_change_case_of_letters()
        {
            //Arrange
            string input = "ACXz";

            //Act

            string output = Program.ProcessInput(input);

            //Assert

            Assert.AreEqual("acxz", output);

        }


        [TestMethod]
        public void Program_handles_invalid_input()
        {
            //Arrange
            string input = "--+++===...";

            //Act

            string output = Program.ProcessInput(input);

            //Assert

            Assert.AreEqual(string.Empty, output);

        }

    }


}
