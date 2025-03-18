using UmasankarTestC;

namespace UmasanakrTestc_.Tests
{
    [TestClass]
    public class EmployeeClassTests
    {
        [TestMethod]
        public void Performwork_Add_NoofHoursWorked()
        {
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            int noofhours = 3;
            bethany.PerformWork(noofhours);
            Assert.AreEqual(noofhours, bethany.NumberOfHoursWorked);

        }
    }

}
