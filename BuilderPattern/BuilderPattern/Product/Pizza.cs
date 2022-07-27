namespace BuilderPattern.Product
{
    public class Pizza
    {
        private string _name;
        private int _size;
        private bool _cheese;
        private bool _sauce;

        public Pizza(string name, int size, bool cheese, bool sauce)
        {
            _name = name;
            _size = size;
            _cheese = cheese;
            _sauce = sauce;
        }

        public void PrintPizza()
        {
            var msg = $"Pizza {_name}, Size {_size}";
            
            if (_cheese)
                msg += ", has cheese";

            if (_sauce)
                msg += ", has sauce";

            Console.WriteLine(msg);
        }
    }
}
