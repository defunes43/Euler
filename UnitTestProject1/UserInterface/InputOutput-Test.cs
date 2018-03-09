using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.UserInterface;

namespace EulerTests.UserInterface
{
    [TestClass]
    public class InputOutputTest
    {
        [TestMethod]
        public void ReadInteger_InputIsInteger()
        {
            //Arrange
            const int testInteger = 5;
            IUserInterface userInterface = new MockUI(testInteger.ToString());

            //Act
            InputOutput IOManager = new InputOutput(userInterface);
            int readInteger = IOManager.ReadInteger();

            //Assert
            Assert.AreEqual(testInteger, readInteger);
        }

    }
}