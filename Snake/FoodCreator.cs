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
            p.x = new Random().Next(2, mapWidth - 2);
            p.y = new Random().Next(2, mapHeight - 2);
            p.sym = sym;
            return p;
        }
    }
}