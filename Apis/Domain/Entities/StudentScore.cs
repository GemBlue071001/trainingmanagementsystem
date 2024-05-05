namespace Domain.Entities
{
    public class StudentScore : BaseEntity
    {
        public double QuizSchema { get; set; }
        public double AsignmentScheme { get; set; }
        public double FinalScheme { get; set; }
        public double FinalTheoryScheme { get; set; }
        public double FinalPractice { get; set; }
        public double GPA { get; set; }
    }
}
