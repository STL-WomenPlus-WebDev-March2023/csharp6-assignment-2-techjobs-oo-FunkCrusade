using System;
namespace TechJobsOOAutoGraded6
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
        {
        }
    }
}



    /*{
        private int id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Task 2: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
} */

