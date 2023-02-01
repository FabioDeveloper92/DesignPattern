using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    public class HomeFacade
    {
        private Bricklayer Bricklayer { get; set; }
        private Plumber Plumber { get; set; }
        private Painter Painter { get; set; }
        public HomeFacade()
        {
            Bricklayer = new Bricklayer();
            Plumber = new Plumber();
            Painter = new Painter();
        }

        public void Build()
        {
            Bricklayer.Build();
            Plumber.Build();
            Painter.Build();
        }

        public void FixWall()
        {
            Bricklayer.FixWall();
            Painter.Build();
        }
    }
}
