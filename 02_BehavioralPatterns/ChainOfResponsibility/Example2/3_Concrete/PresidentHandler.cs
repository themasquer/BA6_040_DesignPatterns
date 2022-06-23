using _02_BehavioralPatterns.ChainOfResponsibility.Example2._1_Model;
using _02_BehavioralPatterns.ChainOfResponsibility.Example2._2_Abstract;

namespace _02_BehavioralPatterns.ChainOfResponsibility.Example2._3_Concrete
{
    public class PresidentHandler : ExpenseHandlerBase
    {
        public override void Handle(ExpenseModel expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled this expense.");
            }
            else
            {
                Console.WriteLine("Expense not handled!");
            }
        }
    }
}
