namespace Tic_Tack_Toe_Web.Client.Classes;

public class GameGrid
{
    public GameGrid(int width, int height)
    {
        Grid = CreateGrid(width, height);
    }

    public Dictionary<int, List<GridItem>> Grid { get; set; }

    public struct GridItem(int itemNum)
    {
        public int itemNum = itemNum;
        public bool? selected = null;
    }

    private Dictionary<int, List<GridItem>> CreateGrid(int width, int height)
    {
        Dictionary<int, List<GridItem>> grid = new();

        for (int i = 0; i < height; i++)
        {
            grid[i] = new();

            for (int j = 0; j < width; j++)
            {
                grid[i].Add(new GridItem(j));
            }
        }

        return grid;
    }
}
