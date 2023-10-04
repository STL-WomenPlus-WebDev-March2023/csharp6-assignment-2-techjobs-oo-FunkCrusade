using System;

namespace TechJobsOOAutoGraded6
{
	public class Job
    { 
            public int Id { get; }
            private static int nextId = 1;
            public string Name { get; set; }
            public Employer EmployerName { get; set; }
            public Location EmployerLocation { get; set; }
            public PositionType JobType { get; set; }
            public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employername, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employername;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
           
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }


        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            //5:3
            if (Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            //test 5:1 + 5:2
            return Environment.NewLine + "ID: " + Id
                + Environment.NewLine + "Name: " + Name
                + Environment.NewLine + "Employer: " + EmployerName.Value
                + Environment.NewLine + "Location: " + EmployerLocation.Value
                + Environment.NewLine + "Position Type: " + JobType.Value
                + Environment.NewLine + "Core Competency: "+ JobCoreCompetency.Value
                + Environment.NewLine;
        }

 
    }
  }


