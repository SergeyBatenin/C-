namespace Snake
{
    public class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            Point p = new Point();
            p.x = new Random().Next(3, mapWidth - 3);
            p.y = new Random().Next(3, mapHeight - 3);
            p.sym = sym;
            return p;
        }
    }
}