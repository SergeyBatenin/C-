namespace Snake
{
    public class Wall
    {
        List<Figure> wallList;

        public Wall(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine topBorder = new HorizontalLine(2, mapWidth - 2, 2, '#');
            HorizontalLine botBorder = new HorizontalLine(2, mapWidth - 2, mapHeight - 2, '#');
            VerticalLine leftBorder = new VerticalLine(2, 2, mapHeight - 2, '#');
            VerticalLine rightBorder = new VerticalLine(mapWidth - 2, 2, mapHeight - 2, '#');
            wallList.Add(topBorder);
            wallList.Add(botBorder);
            wallList.Add(leftBorder);
            wallList.Add(rightBorder);
        }

        internal bool IsHit(Figure figure)
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