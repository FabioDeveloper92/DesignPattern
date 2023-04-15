using TemplateMethodPattern.AbstractClass;

namespace TemplateMethodPattern.ConcreteClass
{
    public class Basketball : Game
    {

        public override void EndGame()
        {
            Console.WriteLine("Finish the Basketball match");
        }

        public override void StartGame()
        {
            Console.WriteLine("Start the Basketball match");
        }
    }
}
