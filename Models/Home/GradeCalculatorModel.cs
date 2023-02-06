using System.ComponentModel.DataAnnotations;

namespace Mission5.Models.Home
{
    public class GradeCalculatorModel
    {
        public string? LetterGrade { get; set; }
        [Range(0,100, ErrorMessage ="Please enter an assignment percent that is between 0-100")]
        public int Assignments { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Please enter a group project percent that is between 0-100")]
        public int GroupProject { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Please enter a quiz percent that is between 0-100")] 
        public int Quizzes { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Please enter a midterm percent that is between 0-100")] 
        public int Midterm { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Please enter a final percent that is between 0-100")] 
        public int Final { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Please enter an intex percent that is between 0-100")] 
        public int Intex { get; set; } = 0;
        public GradeCalculatorModel()
        {

        }

        public GradeCalculatorModel(int assignments, int groupProject, int quizzes, int midterm, int final, int intex)
        {
            Assignments = assignments;
            GroupProject = groupProject;
            Quizzes = quizzes;
            Midterm = midterm;
            Final = final;
            Intex = intex;
        }
    }
}
