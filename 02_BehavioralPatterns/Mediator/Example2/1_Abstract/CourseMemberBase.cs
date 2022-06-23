using _02_BehavioralPatterns.Mediator.Example2._3_Mediator;

namespace _02_BehavioralPatterns.Mediator.Example2._1_Abstract
{
    public abstract class CourseMemberBase
    {
        public string Name { get; set; }

        private readonly CourseMediator _courseMediator;

        protected CourseMemberBase(CourseMediator courseMediator, string name)
        {
            _courseMediator = courseMediator;
            Name = name;
        }

        public void Ask(string question) => _courseMediator.ReceiveQuestion(question, this);
        public void Answer(string answer) => _courseMediator.ReceiveAnswer(answer);
    }
}
