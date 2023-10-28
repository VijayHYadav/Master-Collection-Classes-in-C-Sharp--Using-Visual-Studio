namespace NUnitTestProject
{
    public class Tests
    {
        [Test]
        public void ArrayListCreate_PassIntegers_ReturnsIntegerArray()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int c = 30;
            //Act
            var outputResult = Ex_ArrayList.Program.ArrayListCreate(a, b, c);
            //Assert
            Assert.AreEqual(10, outputResult[0]);
            Assert.AreEqual(20, outputResult[1]);
            Assert.AreEqual(30, outputResult[2]);

        }
    }
}