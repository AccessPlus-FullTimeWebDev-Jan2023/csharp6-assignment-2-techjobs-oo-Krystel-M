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
        public Job(string name, Employer employername, Location employerLocation, PositionType jobtype, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employername;
            EmployerLocation = employerLocation;
            JobType = jobtype;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Task 3: Generate Equals() and GetHashCode() methods.  
        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }
        public override int GetHashCode()
        {
            {
                return HashCode.Combine(Id);
            }
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            if (Name == "") 
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            return $"{Environment.NewLine}ID: {Id}{Environment.NewLine}Name: {Name}{Environment.NewLine}Employer: {EmployerName}" +
                          $"{Environment.NewLine}Location: {EmployerLocation}{Environment.NewLine}Position Type: {JobType}" +
                          $"{Environment.NewLine}Core Competency: {JobCoreCompetency}{Environment.NewLine}";
        }

    }
}

