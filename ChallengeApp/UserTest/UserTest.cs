using ChallengeApp;

namespace UserTest
{
    public class Tests
    {

        [Test]
        public void ReferenceTypeTest()
        {  
            Assert.Pass();

            //Arrange
            var employer1 = GetEmployer("Andzej", "Kowalski", 31, 10);
            var employer2 = GetEmployer("Andzej", "Kowalski", 31, 10);

            //Act
            
            //Assert
            Assert.AreEqual(employer1, employer2);
        }

        private Employe GetEmployer(string name,string surname, int age, int score) 
        {
            return new Employe(name, surname, age, score);  
        }

        [Test]
        public void IntTypeTest()
        {
            //Arrange
            int intValues1 = 1;
            int intValues2 = 1;
            //Act

            //Assert
            Assert.AreEqual(intValues1, intValues2);
        }
        [Test]
        public void FloatTypeTest()
        {
            //Arrange
            float floatValues1 = 1.2f;
            float floatValues2 = 1.2f;
            //Act

            //Assert
            Assert.AreEqual(floatValues1, floatValues2);
        }
        [Test]
        public void StringTypeTest()
        {
            //Arrange
            string stringValues1 = "Name";
            string stringValues2 = "Name";
            //Act

            //Assert
            Assert.AreEqual(stringValues1, stringValues2);
        }
    }
}