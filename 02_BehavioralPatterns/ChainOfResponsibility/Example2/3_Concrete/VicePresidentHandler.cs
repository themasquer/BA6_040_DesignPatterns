using _02_BehavioralPatterns.ChainOfResponsibility.Example2._1_Model;
using _02_BehavioralPatterns.ChainOfResponsibility.Example2._2_Abstract;

namespace _02_BehavioralPatterns.ChainOfResponsibility.Example2._3_Concrete
{
    public class VicePresidentHandler : ExpenseHandlerBase
    {
        public override void Handle(ExpenseModel expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President handled this expense.");
            }
            else
            {
                if (_successor != null)
                {
                    _successor.Handle(expense);
                }
            }
        }
    }
}
