namespace Hello_World
{
    public class Product
    {
        public string Id;
        public string Code;
        public string Name;
        public string Description;
        public int Height;
        public int Depth;
        public int Width;

        public int Volume
         {
            get
            {
                return Height*Width*Depth;
            }
         }
        public Product(string id, string code, string name, string description, int height, int depth, int width)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            Height = height;
            Depth = depth;
            Width = width;
        }
         
    }
}