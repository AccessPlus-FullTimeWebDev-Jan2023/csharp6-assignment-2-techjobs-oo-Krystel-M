namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {

            Job job1 = new Job();
            Job job2 = new Job();
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        //Testing Objects
        //initalize your testing objects here

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3 == job4);
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));

        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expectedOutput = @$"
            ID: {job4.Id}
            Name: {job4.Name}
            Employer: {job4.EmployerName}
            Location: {job4.EmployerLocation}
            Position Type: {job4.JobType}
            Core Competency: {job4.JobCoreCompetency}
            ";
            string actualOutput = job4.ToString();
            Assert.AreEqual(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            job3.Name = string.Empty;
            job3.EmployerName.Value = string.Empty;
            job3.EmployerLocation.Value = string.Empty;
            job3.JobType.Value = string.Empty;
            job3.JobCoreCompetency.Value = string.Empty;

            string expectedOutput = @$"
            ID: {job3.Id}
            Name: Data not available
            Employer: Data not available
            Location: Data not available
            Position Type: Data not available
            Core Competency: Data not available
            ";

            Assert.AreEqual(expectedOutput, job3.ToString());

        }
    }
}




