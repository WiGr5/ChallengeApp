using ChallengeApp;

namespace UserTest
{
    public class Tests
    {

        [Test]
        public void WhenEmployeAddPoint_ShouldReturnUserResult()
        {
            Assert.Pass();

            //Arrange
            var employe1 = new Employe("Andzej", "Kowalski", 26, 0);
            employe1.AddScore(2);
            employe1.AddScore(5);
            employe1.AddScore(3);
            employe1.AddScore(-6);
            employe1.AddScore(-1);

            //Act
            var result = employe1.ResultScore;
            //Assert
            Assert.AreEqual(3, result);
        }
    }
}