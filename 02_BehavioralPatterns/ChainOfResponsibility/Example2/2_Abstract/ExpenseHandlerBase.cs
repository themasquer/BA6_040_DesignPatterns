using _02_BehavioralPatterns.ChainOfResponsibility.Example2._1_Model;

namespace _02_BehavioralPatterns.ChainOfResponsibility.Example2._2_Abstract
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase _successor;

        public void SetSuccessor(ExpenseHandlerBase successor) => _successor = successor;

        public abstract void Handle(ExpenseModel expense);
    }
}
