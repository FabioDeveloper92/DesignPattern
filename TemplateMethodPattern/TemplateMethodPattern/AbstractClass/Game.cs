namespace TemplateMethodPattern.AbstractClass
{
    public abstract class Game
    {
        // Template method, it's only implement in the superclass
        public void Play()
        {
            StartGame();
            Break();
            EndGame();
        }

        // Hook method, it's implement in the superclass but if a subclass need a change, you can override it
        public virtual void Break()
        {
            Console.WriteLine("Drink Water");
        }

        // Primitive method, it must implemente in the subclass
        public abstract void StartGame();

        public abstract void EndGame();
    }
}
