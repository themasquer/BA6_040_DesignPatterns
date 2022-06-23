using _02_BehavioralPatterns.Mediator.Example2._1_Abstract;
using _02_BehavioralPatterns.Mediator.Example2._3_Mediator;

namespace _02_BehavioralPatterns.Mediator.Example2._2_Concrete
{
    public class Teacher : CourseMemberBase
    {
        public Teacher(CourseMediator courseMediator, string name) : base(courseMediator, name)
        {
        }
    }
}
