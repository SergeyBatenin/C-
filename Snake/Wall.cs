namespace Snake
{
    public class Wall
    {
        List<Figure> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topBorder = new HorizontalLine(1, mapWidth - 1, 1, '#');
            HorizontalLine botBorder = new HorizontalLine(1, mapWidth - 1, mapHeight - 1, '#');
            VerticalLine leftBorder = new VerticalLine(1, 1, mapHeight - 1, '#');
            VerticalLine rightBorder = new VerticalLine(mapWidth - 1, 1, mapHeight - 1, '#');
            wallList.Add(topBorder);
            wallList.Add(botBorder);
            wallList.Add(leftBorder);
            wallList.Add(rightBorder);
        }

        internal bool isHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
            Console.ResetColor();
        }
    }
}