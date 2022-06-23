using _02_BehavioralPatterns.ChainOfResponsibility.Example1._1_Abstract;
using _02_BehavioralPatterns.ChainOfResponsibility.Example1._2_Concrete;
using _02_BehavioralPatterns.ChainOfResponsibility.Example2._1_Model;
using _02_BehavioralPatterns.ChainOfResponsibility.Example2._2_Abstract;
using _02_BehavioralPatterns.ChainOfResponsibility.Example2._3_Concrete;
using _02_BehavioralPatterns.Mediator.Example1._1_Interface;
using _02_BehavioralPatterns.Mediator.Example1._2_Concrete;
using _02_BehavioralPatterns.Mediator.Example1._3_Mediator._1_Interface;
using _02_BehavioralPatterns.Mediator.Example1._3_Mediator._2_Concrete;
using _02_BehavioralPatterns.Mediator.Example2._2_Concrete;
using _02_BehavioralPatterns.Mediator.Example2._3_Mediator;

#region 2) Behavioral Patterns

#region I) Mediator

#region Example 1
IChatMediator chatMediator = new ChatMediator();

IUser user1 = new GoldUser(chatMediator, "Çağıl");
IUser user2 = new BasicUser(chatMediator, "Leo");
IUser user3 = new BasicUser(chatMediator, "Angel");

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);
chatMediator.AddUser(user3);

user1.SendMessage("Hello, I'm Çağıl!");
Console.WriteLine();
user2.SendMessage("Hello, I'm Leo!");
#endregion

Console.WriteLine();

#region Example 2
CourseMediator courseMediator = new CourseMediator();

Teacher teacher = new Teacher(courseMediator, "Çağıl");
Student student1 = new Student(courseMediator, "Leo");
Student student2 = new Student(courseMediator, "Angel");

courseMediator.Teacher = teacher;
courseMediator.Students = new List<Student>() { student1, student2 };

student1.Ask("What is C#?");
teacher.Answer("C# is a programming language.");

Console.WriteLine();

student2.Ask("What is the best video game?");
teacher.Answer("Red Dead Redemption 2.");
#endregion

#endregion

Console.WriteLine();

#region II) Chain of Responsibility

#region Example 1
// Zincirin halkaları:
PlayerHandlerBase aviPlayer = new AviHandler();
PlayerHandlerBase mp3Player = new Mp3Handler();
PlayerHandlerBase mp4Player = new Mp4Handler();

// Zincirin oluşturulması:
mp4Player.NextPlayerHandler = mp3Player;
mp3Player.NextPlayerHandler = aviPlayer;

// İsteklerin zincire gönderilmesi:
mp4Player.Play("file1.mp4");
mp4Player.Play("file2.mp3");
mp4Player.Play("file3.avi");
mp4Player.Play("file4.txt");
#endregion

Console.WriteLine();

#region Example 2
// Zincirin halkaları:
ExpenseHandlerBase president = new PresidentHandler();
ExpenseHandlerBase vicePresident = new VicePresidentHandler();
ExpenseHandlerBase manager = new ManagerHandler();

// Zincirin oluşturulması:
manager.SetSuccessor(vicePresident);
vicePresident.SetSuccessor(president);

// İsteklerin zincire gönderilmesi:
List<ExpenseModel> expenses = new List<ExpenseModel>()
{
    new ExpenseModel() { Description = "C# Course", Amount = 90 },
    new ExpenseModel() { Description = "Object Oriented Course", Amount = 500 },
    new ExpenseModel() { Description = "ASP.NET Core Course", Amount = 1100 }
};

foreach (var expense in expenses)
{
    manager.Handle(expense);
}
#endregion

#endregion

#endregion