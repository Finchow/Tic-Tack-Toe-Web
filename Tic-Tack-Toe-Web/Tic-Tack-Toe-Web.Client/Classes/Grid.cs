using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tack_Toe_Web.Client.Classes;

public class Grid
{
    public Grid(int width, int height)
    {
        Tiles = CrateGrid(width, height);
        Width = width;
        Height = height;
    }

    public List<Tile> Tiles { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    private static List<Tile> CrateGrid(int x, int y)
    {
        var tileNum = x * y;

        List<Tile> gameGrid = [];

        for (int i = 0; i < tileNum; i++)
        {
            Tile tile = new();
            gameGrid.Add(tile);
        }

        return gameGrid;
    }
}
