
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        //initalize your testing objects here
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        //TASK 4:
        //1-Using job1 and job2, compare two empty constructor Job objects. Use Assert.AreEqual,
        //Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1.

        [TestMethod] //4:1
      public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id.Equals(job2.Id));
            Assert.AreEqual(job2.Id - job1.Id, 1);
        }

       // Select one of the Job objects with the full constructor to test that the object is assigned the correct properties.
       // Use Assert statements to test that the constructor correctly assigns the value of each field.
    
        [TestMethod] //task 4: 2
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }

        //Test the Equals Method (no scenario where jobs will have the same id #)
        [TestMethod] // 4:3
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Equals(job2));
            Assert.IsFalse(job1.Equals(job3));
            Assert.IsFalse(job3.Equals(job4));
        }

        //BEGINGING OF TASK 5:

        //when job object is passed it starts and ends with a blank line (enivironment.newline)
        [TestMethod] // 5:1
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job4.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job4.ToString().EndsWith(Environment.NewLine));
        }

        //String contains labels printed to console for each feild listed
        [TestMethod] // 5:2
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job4.ToString().Equals(
                 Environment.NewLine + "ID: " + job4.Id
                + Environment.NewLine + "Name: " + job4.Name
                + Environment.NewLine + "Employer: " + job4.EmployerName
                + Environment.NewLine + "Location: " + job4.EmployerLocation
                + Environment.NewLine + "Position Type: " + job4.JobType
                + Environment.NewLine + "Core Competency: " + job4.JobCoreCompetency
                + Environment.NewLine
                ));
        }

        //empty feild adds "Data not available" after the label
            [TestMethod] // 5:3
            public void TestToStringHandlesEmptyField()
            {
            job3.EmployerLocation.Value = "";

            Assert.IsTrue(job3.ToString().Equals(
                Environment.NewLine + "ID: " + job3.Id
            + Environment.NewLine + "Name: " + job3.Name
            + Environment.NewLine + "Employer: " + job3.EmployerName
            + Environment.NewLine + "Location: " + "Data not available"
            + Environment.NewLine + "Position Type: " + job3.JobType
            + Environment.NewLine + "Core Competency: " + job3.JobCoreCompetency
            + Environment.NewLine
                ));
            }      
    }
}

