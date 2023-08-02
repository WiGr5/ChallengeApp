using ChallengeApp; 

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ValueStatisticsMinTest()
        {
            //Arrange

            var employee1 = new Employee("Andzej", "Kowalski");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(6);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(1, statistics.Min);
            
        }

        [Test]
        public void ValueStatisticsMaxTest()
        {
            //Arrange

            var employee1 = new Employee("Andzej", "Kowalski");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(6);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void ValueStatisticAvrTest()
        {
            //Arrange

            var employee1 = new Employee("Andzej", "Kowalski");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(6);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(3.5f, statistics.Average);

        }
        [Test]
        public void ValueStatisticImputLeterTest()
        {
            //Arrange

            var employee1 = new Employee("Andzej", "Kowalski");
            employee1.AddGrade("A");
            employee1.AddGrade('f');

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(50, statistics.Average);

        }
        [Test]
        public void ValueStatisticOutputLeterTest()
        {
            //Arrange

            var employee1 = new Employee("Andzej", "Kowalski");
            employee1.AddGrade("A");
            employee1.AddGrade('E');

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual('C', statistics.AverageLetter);

        }
    }
}