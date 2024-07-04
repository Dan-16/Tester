namespace Hello_World
{
    public class Location
    {
        public Store? Store;
        public string Name;
        public int Height;
        public int Width;
        public int Depth;
        public Location(string name, int height, int width, int depth)
        {
            Name = name;
            Height = height;
            Width = width;
            Depth = depth;
        }
         public int Volume
         {
            get
            {
                return Height*Width*Depth;
            }
         }
        public void setStore(Store store)
        {
            Store = store;
        }
    }
}