using TemplateMethodPattern.AbstractClass;

namespace TemplateMethodPattern.ConcreteClass
{
    public class FootBall : Game
    {
        public override void Break()
        {
            Console.WriteLine("They go to the locker room, and drink water");
        }

        public override void EndGame()
        {
            Console.WriteLine("Finish the Football match");
        }

        public override void StartGame()
        {
            Console.WriteLine("Start the Football match");
        }
    }
}
