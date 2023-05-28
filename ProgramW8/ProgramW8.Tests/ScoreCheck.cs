namespace ProgramW8.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeScoreSumCheck()
        {
            //arrange
            var employee = new Employee("Adam");
            employee.AddPoints(3);
            employee.AddPoints(8);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
}