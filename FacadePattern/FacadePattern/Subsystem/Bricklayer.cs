namespace FacadePattern.Subsystem
{
    public class Bricklayer
    {
        public Bricklayer()
        {
        }

        public void Build()
        {
            Console.WriteLine("Bricklayer builds...");
        }
        public void FixWall()
        {
            Console.WriteLine("Bricklayer breaks the wall...");
            Console.WriteLine("Bricklayer fixs...");
        }
    }
}
