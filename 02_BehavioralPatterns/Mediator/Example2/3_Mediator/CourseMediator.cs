using _02_BehavioralPatterns.Mediator.Example2._1_Abstract;
using _02_BehavioralPatterns.Mediator.Example2._2_Concrete;

namespace _02_BehavioralPatterns.Mediator.Example2._3_Mediator
{
    public class CourseMediator
    {
        public Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }

        public void ReceiveQuestion(string question, CourseMemberBase courseMember) => Console.WriteLine($"Question from student \"{courseMember.Name}\" to teacher \"{Teacher.Name}\": {question}");
        public void ReceiveAnswer(string answer)
        {
            string studentNames = "";
            foreach (Student student in Students)
            {
                studentNames += $"\"{student.Name}\", ";
            }
            studentNames = studentNames.TrimEnd(',', ' ');
            Console.WriteLine($"Answer from teacher \"{Teacher.Name}\" to students {studentNames}: {answer}");
        } 
    }
}
