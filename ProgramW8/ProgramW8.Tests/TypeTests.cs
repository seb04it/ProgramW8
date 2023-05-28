namespace ProgramW8.Tests
{
    public class TypeTests
    {
        [Test]
        public void UserNameCheck()
        {
            //arrange
            var employee0 = GetUser("Adam");
            var employee1 = GetUser("Adam");

            //act

            //assert
            Assert.AreEqual(employee0.Name, employee1.Name);
        }
        [Test]
        public void UserDifferenceCheck()
        {
            //arrange
            var employee0 = GetUser("Mariusz");
            var employee1 = GetUser("Mariusz");

            //act

            //assert
            Assert.AreNotEqual(employee0, employee1);
        }
        [Test]
        public void LoginSimilarityCheck()
        {
            //arrange
            string login0 = "Edyta";
            string login1 = "Oliwia";

            //act

            //assert
            Assert.AreNotSame(login0, login1);
        }
        [Test]
        public void NumberGreaterOrEqualCheck()
        {
            //arrange
            int number0 = 14;
            int number1 = 5;

            //act

            //assert
            Assert.Greater(number0, number1);
        }
        [Test]
        public void FloatsEqualityCheck()
        {
            //arrange
            float largenumber = 340282346638528859;
            float largenumberbutdiffrent = -340282346638528859;

            //act

            //assert
            Assert.LessOrEqual(largenumberbutdiffrent, largenumber);
        }
        [Test]
        public void PrepareForTrubleAndMakeItADouble()
        {
            //arrange
            double Jessie = 1797693134862315;
            double James = -1797693134862315;

            //act
            double battlepower = Jessie + James;

            //assert
            Assert.Zero(battlepower);
        }
        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}
