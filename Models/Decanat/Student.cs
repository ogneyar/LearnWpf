
using System.Security.Cryptography.X509Certificates;

namespace LearnWpf.Models.Decanat
{
    class Student
    {
        public string Name { get; set; }

        public string Surename { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surename} {Patronymic}";
        }
    }
    class Group
    {
        public string Name { get; set; }

        public IList<Student> Students { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {Description}";
        }
    }
}
